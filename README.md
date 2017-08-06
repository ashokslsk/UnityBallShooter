# Unity

Writing 3D game. 

Scene is a collection object, Which we can use to express the game or unity application. 

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

 