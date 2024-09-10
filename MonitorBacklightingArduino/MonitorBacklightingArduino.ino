#include <FastLED.h>
#include <EEPROM.h>
// Количество светодиодов в ленте
#define NUM_LEDS 55
// Пин, к которому подключена лента
#define DATA_PIN 13
// Пин к которому подключено реле
#define RELAY_IN 5

CRGB leds[NUM_LEDS];
int hell = 255;
int speed = 15;

int R = 255;
int G = 0;
int B = 255;

void setup() {
  // put your setup code here, to run once:
  pinMode(RELAY_IN, OUTPUT);
  Serial.begin(9600);
  FastLED.addLeds<NEOPIXEL, DATA_PIN>(leds, NUM_LEDS);
  FastLED.setBrightness(255);

}

void smooth_rainbow(){  //плавная радуга  +
  // Проход по всем оттенкам радуги
  for (int i = 0; i < 256; i++) {
    // Установка всех светодиодов в один цвет
     for (int j = 0; j < NUM_LEDS; j++) {
      leds[j] = CHSV(i, 255, 255);
    }
    FastLED.setBrightness(hell);

    // Отображение обновленного состояния ленты
    FastLED.show();

    // Задержка для плавного перехода
    delay(20);
  }
}

void smooth_running_rainbow(){  //плавная бегущая радуга +
  for (int i = NUM_LEDS - 1; i > 0; i--) {
    leds[i] = leds[i - 1];
  }
  // Вычисляем новый цвет для первого светодиода
  int hue = millis() / 20 % 255;
  leds[0] = CHSV(hue, 255, 255);
  FastLED.setBrightness(hell);
  FastLED.show();
  delay(speed);
}

void breath(){ // дыхание
  // Плавное включение
  for (int i = 0; i < 255; i++) {
    for (int j = 0; j < NUM_LEDS; j++) {
      leds[j] = CRGB(R, G, B);
    }
    FastLED.setBrightness(i);
    FastLED.show();
    delay(speed);
  }

  // Плавное выключение
  for (int i = 255; i >= 0; i--) {
    for (int j = 0; j < NUM_LEDS; j++) {
      leds[j] = CRGB(R, G, B);
    }
    FastLED.setBrightness(i);
    FastLED.show();
    delay(speed);
  }
}

void paint_the_tape_in(){  // покарсить всё в один цыет
  for (int i = 0; i < NUM_LEDS; i++) {
    leds[i] = CRGB(0xFF, 0x50, 0x00); 
    FastLED.setBrightness(hell);
  }
  FastLED.show();
}



void fire() {
  

}

void loop() {
  // put your main code here, to run repeatedly:

  digitalWrite(RELAY_IN, 1);

  //smooth_rainbow();

  //smooth_running_rainbow();

  breath();
  
  //fire();
  

}
