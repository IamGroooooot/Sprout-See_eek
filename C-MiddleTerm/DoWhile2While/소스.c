#include <stdio.h>

//Do while to while
void main(void) {
	int num=1;
	do
	{
		printf("�ƹ� �� �Է�\n(Ż���Ϸ��� 0�Է�): ");
		scanf("%d",&num);
	} while (num);

	printf("------------------------END of DoWhile-------------------------\n");
	printf("�ƹ� �� �Է�\n(Ż���Ϸ��� 0�Է�): ");
	scanf("%d", &num);
	while (num) {
		printf("�ƹ� �� �Է�\n(Ż���Ϸ��� 0�Է�): ");
		scanf("%d", &num);
	}
	printf("------------------------END of While-------------------------\n");

}