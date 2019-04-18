#include <stdio.h>

//Do while to while
void main(void) {
	int num=1;
	do
	{
		printf("아무 수 입력\n(탈출하려면 0입력): ");
		scanf("%d",&num);
	} while (num);

	printf("------------------------END of DoWhile-------------------------\n");
	printf("아무 수 입력\n(탈출하려면 0입력): ");
	scanf("%d", &num);
	while (num) {
		printf("아무 수 입력\n(탈출하려면 0입력): ");
		scanf("%d", &num);
	}
	printf("------------------------END of While-------------------------\n");

}