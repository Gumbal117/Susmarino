const int pinBoton1= 2; //declaramos constantes con numero de pin para los botones
const int pinBoton2= 3;
const int pinBoton3= 4;
const int pinBoton4= 5;
 
int valorBoton1= 0; //declaramos variables para almacenar el estado de los botones
int valorBoton2= 0;
int valorBoton3= 0;
int valorBoton4= 0;
int joyX;
int joyY;
int joyXMap;
int joyYMap;
 
 
 
void setup(void){
  Serial.begin(9600);
  pinMode (pinBoton1, INPUT);
  pinMode (pinBoton2, INPUT);
  pinMode (pinBoton3, INPUT);
  pinMode (pinBoton4, INPUT);
}
 
void loop(void)
{
  valorBoton1=digitalRead (pinBoton1); //leemos pines donde hemos conectado los botones
  valorBoton2=digitalRead (pinBoton2);
  valorBoton3=digitalRead (pinBoton3);
  valorBoton4=digitalRead (pinBoton4);
  joyX=analogRead (A0); //leemos las entradas analógicas donde hemos conectado el Joystick
  joyY=analogRead (A1);
  
  joyXMap=map(joyX, 0, 1024, -45, 45); //mapeamos los valores de Joustick para darle el rango deseado
  joyYMap=map(joyY, 0, 1024,  -45, 45);
 
    Serial.flush(); //escribimos los valores en el serial
    Serial.print(valorBoton1);
    Serial.print(",");
    Serial.print(valorBoton2);
    Serial.print(",");
    Serial.print(valorBoton3);
    Serial.print(",");
    Serial.print(valorBoton4);
    Serial.print(",");
    Serial.print(joyXMap);
    Serial.print(",");
    Serial.print(joyYMap);
    Serial.println();
    
    delay(50);
 
}
