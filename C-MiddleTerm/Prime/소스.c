#include <stdio.h>
#include <math.h>

void main(void) {
	int MAX = 100;

	for (int i = 2;i <= MAX;i++) {
		int hasDiv = 0;
		for (int div = 2;div <= sqrt(i);div++) {
			// ���� ����
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