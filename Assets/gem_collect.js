function OnTriggerEnter (info : Collider) {
    Destroy(gameObject);
    GemScore.gscore += 1;
}