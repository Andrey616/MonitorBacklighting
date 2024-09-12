#include <FastLED.h>
#include <EEPROM.h>
#include <GParser.h>

// Количество светодиодов в ленте
#define NUM_LEDS 55
// Пин, к которому подключена лента
#define DATA_PIN 13


unsigned long timeRead;
unsigned long time;

CRGB leds[NUM_LEDS];

char str[30];

int mode = 3;
int hell = 100;
int speed = 100;

int R = 255;
int G = 0;
int B = 255;
int CollorTop = 0;

int tapeWhite = 0;

void setup() {

  Serial.begin(9600);
  FastLED.addLeds<NEOPIXEL, DATA_PIN>(leds, NUM_LEDS);
  
}

void smooth_rainbow(){  //плавная радуга  +
  
  // Проход по всем оттенкам радуги
  for (int i = 0; i < 256;) {
    if (millis() - time > speed){ 
      time = millis();
      // Установка всех светодиодов в один цвет
      for (int j = 0; j < NUM_LEDS; j++) {
        leds[j] = CHSV(i, 255, 255);
      }
      FastLED.setBrightness(hell);
      FastLED.show();
      i++;
    }
    readData();
    if (mode != 0){ break;}
  }
}

void smooth_running_rainbow(){  //плавная бегущая радуга +
  if (millis() - time > speed){ 
    time = millis();
    for (int i = NUM_LEDS - 1; i > 0; i--) {
      leds[i] = leds[i - 1];
    }
    // Вычисляем новый цвет для первого светодиода
    int hue = millis() / 20 % 255;
    leds[0] = CHSV(hue, 255, 255);
    FastLED.setBrightness(hell);
    FastLED.show();
  }
  readData();
}

void breath(){ // дыхание
  // Плавное включение
  for (int i = 0; i < hell;) {
    if (millis() - time > speed / (hell / 25)){ 
      time = millis();
      for (int j = 0; j < NUM_LEDS; j++) {
        leds[j] = CRGB(R, G, B);
      }
      FastLED.setBrightness(i);
      FastLED.show();
      i++;
    }
    readData();
    if (mode != 2){ break;}
  }

  // Плавное выключение
  for (int i = hell; i >= 0;) {
    if (millis() - time > speed / (hell / 25)){ 
      time = millis();
      for (int j = 0; j < NUM_LEDS; j++) {
        leds[j] = CRGB(R, G, B);
      }
      FastLED.setBrightness(i);
      FastLED.show();
      i--;
    }
    readData();
    if (mode != 2){ break;}
  }
}

void paint_the_tape_in(){  // покарсить всё в один цыет
  for (int i = 0; i < NUM_LEDS; i++) {
    leds[i] = CRGB(R, G, B); 
    FastLED.setBrightness(hell);
  }
  FastLED.show();
}

void fire() { // Имитация горения огня
  if (millis() - time > 100){ 
    time = millis();
    for (int i = 0; i < NUM_LEDS; i++) { // 255 255 основной 128 его вспышка 20 добавочный, при обрабртки  получаем ргб и приоритетный цвет от 0 до 1
      int r = random(255, 255);
      int g = random(0, 0);
      int b = random(0, 128);
      leds[i] = CRGB(r, g, b);
    }

    for (int i = 1; i < NUM_LEDS; i++) {
      int brightness = random(80, 150);
      leds[i].nscale8(brightness);
    }
    FastLED.setBrightness(hell);
    FastLED.show();
  }
}

void tapeOff(){
   for (int i = 0; i < NUM_LEDS; i++) {
    leds[i] = CRGB(0, 0, 0); 
    FastLED.setBrightness(hell);
  }
  FastLED.show();
  mode = 100;

}

void readData(){
  if (millis() - timeRead > 0){ 
    timeRead = millis();
    if (Serial.available() > 0) {
      //data = Serial.readStringUntil('\n');
      
      int amount = Serial.readBytesUntil('\n', str, 30);
      str[amount] = NULL;

      GParser data(str, '|');
      int ints[10];

      int am = data.parseInts(ints);
      
      tapeWhite = ints[0];
      mode = ints[1];
      speed = ints[2];
      hell = ints[3] * 25;
      R = ints[4];
      G = ints[5];
      B = ints[6];
      CollorTop = ints[7];
      //0|4|100|5|255|0|0|0
      //включение ленты | режим | скорость | яркость | красный | зелёный | синий | приоритетный
      for (int i = 0; i < am; i++ ){
        Serial.println(ints[i]);
      }
      

      //Serial.println(data + data);
      //Serial.println(data);
      //tapeWhite = atoi(data[1]);
      

      if (tapeWhite == 0){
        tapeOff();
      }
    }
    
    //Serial.println("o");
  }
}

void loop() {
  // принимаю: включение ленты, режим, скорость, яркость,

  
  if (tapeWhite == 0){
    tapeOff();
  }
  readData();
  


  switch (mode) {
    case 0:
      smooth_rainbow();
      break;
    case 1: 
      smooth_running_rainbow();
      break;
    case 2: 
      breath();
      break;
    case 3:
      paint_the_tape_in();
      break;
    case 4:
      fire();
      break;
  }

}
