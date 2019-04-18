#include <stdio.h>

void main(void) {
	int line_MAX=7;

	for (int i = 1;i <= line_MAX/2+1;i++) {
		for (int blank=0;blank<(line_MAX/2+1)-i;blank++) {
			printf(" ");
		}
		for (int star=0;star < 1+2*(i-1);star++) {
			printf("*");
		}
		//Enter
		printf("\n");
	}
	for (int i = 1;i <= line_MAX / 2;i++) {
		for (int blank = 0;blank < i;blank++) {
			printf(" ");
		}
		for (int star = 0;star < 1+2*(line_MAX/2 - i) ;star++) {
			printf("*");
		}
		//Enter
		printf("\n");
	}
}