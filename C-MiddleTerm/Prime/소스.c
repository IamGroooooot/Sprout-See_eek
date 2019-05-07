#include <stdio.h>
#include <math.h>

void main(void) {
	int MAX = 100;

	for (int i = 2;i <= MAX;i++) {

		int hasDiv = 0;
		for (int div = 2;div <= i-1;div++) {
			// 인자 유무
			if (i%div == 0) {
				hasDiv++;
				break;
			}
		}

		// if i does not have any divisor
		if (!hasDiv) {
			printf("%d ",i);
		}
	}
}