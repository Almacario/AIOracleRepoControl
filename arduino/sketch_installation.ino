#include <Ultrasonic.h>
#include <PololuLedStrip.h>

/*
 * STATES LIST:
 * 1:LISTEN DISTANCE SENSORS
 * 2:REVEALED PRESENCE -> VOICE START
 * 3:VOICE ENDED -> LIGHTS ON FOR SCAN
 * 4:SCAN ENDED -> VOICE OF RESULTS
 */

#define LED_COUNT 150
#define N_LED 15
#define LEDSPEED 5

Ultrasonic ultrasonic(5,6); // (Trig PIN,Echo PIN)
PololuLedStrip<12> ledStrip;
rgb_color colors[LED_COUNT];

int startingLed=0;
int vel=1;
int state=1;
int S1value;
int color1[3]={178,51,255};
int color2[3]={51,234,255};
float currentColor[3]={0,0,0};
float offset[3]={float((color1[0]-color2[0])/(LED_COUNT*1.0)),float((color1[1]-color2[1])/(LED_COUNT*1.0)),float((color1[2]-color2[2])/(LED_COUNT*1.0))};
bool start=false;

void lightsSetup();
void sensorSetup();
void lightsMoveset();
void reset();

void setup() {
  Serial.begin(9600);
  reset();
}

void loop() {
  char receiveVal;  

  if(Serial.available() > 0){          
    receiveVal = Serial.read();  
    Serial.print("[ARDUINO:] ");    
    switch(receiveVal){
      case 'a':
        Serial.println("Lights test requested");  
        //CODE FOR LIGHT TEST
        break;
      case 'b':
        Serial.println("Motor test requested");  
        //CODE FOR MOTOR TEST
        break;
      case 'c':
        Serial.println("Smoke test requested");  
        //CODE FOR SMOKE TEST
        break;
      case 'd':
        Serial.println("Sensor test requested");  
        //CODE FOR SENSOR TEST
        break;
      case 'e':
        if(start==true){
          Serial.println("Program stopped"); 
          reset();
          start=false;
        }
        else{
          Serial.println("Program started"); 
          reset();
          start=true;
        }
        break;
      case 'h':
        state=2;
      default:
        break;
    }      
  }
  if(start){
    switch(state){
      case 1:
        sensorOn();
        break;
      case 2:
        lightsMoveset();
        break;
    }
  }
}

void reset(){
  state=1;
  lightsSetup();
  sensorSetup();
}

void sensorSetup(){
  pinMode(4, OUTPUT); // VCC pin
  pinMode(7, OUTPUT); // GND ping
  digitalWrite(4, HIGH); // VCC +5V mode  
  digitalWrite(7, LOW);  // GND mode
  S1value=0;
}

void lightsSetup()
{
  currentColor[0]=color1[0];
  currentColor[1]=color1[1];
  currentColor[2]=color1[2];
  startingLed=0;
  vel=1;
}

void sensorOn(){
    S1value=ultrasonic.Ranging(CM);
    if(S1value<150&&S1value>10){
      Serial.print("D");
  }
}

void lightsMoveset()
{
    currentColor[0]=currentColor[0]+(-vel)*offset[0];
    currentColor[1]=currentColor[1]+(-vel)*offset[1];
    currentColor[2]=currentColor[2]+(-vel)*offset[2];
    
    for (int i = 0; i < LED_COUNT; i++)
    {
      if(i>=startingLed && i<startingLed+N_LED){
        colors[i] = rgb_color(currentColor[0], currentColor[1], currentColor[2]);
      }
      else{
        colors[i] = rgb_color(0, 0, 0);
      }
    }

  startingLed=startingLed+vel;

  if( (startingLed % LED_COUNT)==0)
  {
    if(vel==1){
      vel=(-1);
      currentColor[0]=color2[0];
      currentColor[1]=color2[1];
      currentColor[2]=color2[2];
    }
    else{
      vel=1;
      currentColor[0]=color1[0];
      currentColor[1]=color1[1];
      currentColor[2]=color1[2];
    }
  }
   
  ledStrip.write(colors, LED_COUNT);
  delay(LEDSPEED);
}

