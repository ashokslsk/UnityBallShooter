# Unity

![Balls_shooter](https://github.com/ashokslsk/UnityBallShooter/blob/master/Balls_shooter.png)

Writing 3D game. 

Scene is a collection of object, Which we can use to express the game or unity application. 

Right click in the Assets -> And create a new scene called Main. 

Add cube and using the unity shortcuts Q,W,E,R,T stretch and align the cube as Gym floor. 

**RigidBody Physics**

Add a component to your game object called rigidbody

**Smart copies with prefabs**

Prefabs are like templates, Using prefabs we can customise the 3d object look and feel. 

**Angular Drag** 

Just adds the angular drag on the natural physics motion. Basketball will slow down when this is applied. 

**Instantiate** Method. 

**Spawn a ball on spacebar**

use getKeydown() method

if statement inside Update() method

Instantiate() inside the if condition

**Adding Velocity to the ball**

Directional velocity can be added as shown below. 

```C#
void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.left;
		}
	
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.right;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.up;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.down;
		}

	}
```

**Rotating the camera in the code**

We will rotate the camera based on the concept called Quaternion. 

```c#
// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler (0, 1, 0) * transform.rotation;

	}
```

**Taking mouse input**

Go to edit inside project settings add the **Input** component

then in the component script. 

```c#

	// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		transform.rotation = Quaternion.Euler (-mouseY, mouseX, 0) * transform.rotation;

	}
```

**Creating a camera gimbal**

Using localRotation object we can eliminate the tilting 

```c#
// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation;
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;
	}

```

**Setting the ball location** **and firing**



```c#
	if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward * Speed;
		}
```

