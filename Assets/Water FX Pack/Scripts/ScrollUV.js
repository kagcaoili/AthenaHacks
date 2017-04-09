
var scrollSpeed_X = 0.5;
var scrollSpeed_Y = 0.5;
function Update() {
var offsetX = Time.time * scrollSpeed_X;
var offsetY = Time.time * scrollSpeed_Y;
//renderer.material.mainTextureOffset = Vector2 (offsetX,offsetY);
var mat = GetComponent(Renderer).material;
mat.mainTextureOffset = Vector2(offsetX, offsetY);
//GetComponent<Renderer>().material.mainTextureOffset = Vector2(offsetX, offsetY);
}