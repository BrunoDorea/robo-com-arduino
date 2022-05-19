int trig = 13;
int echo = 12;

float distancia;

void setup () {
    pinMode (trig, OUTPUT);
    pinMode (echo, INPUT);

    Serial.begin(9600);
}

void loop () {
    digitalWrite(trig, HIGH);
    delay(0010);
    digitalWrite(trig, LOW);
    
    distancia = pulseIn (echo, HIGH);
    distancia = distancia/58; 
    // distancia em cm = tempo / 58
    Serial.println(distancia);
}