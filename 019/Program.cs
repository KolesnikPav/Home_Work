// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// X	Y	¬(X ⋁ Y)    =	¬X ⋀ ¬Y
// 0	0	    1	    =	    1
// 0	1	    0	    =	    0
// 1	0	    0	    =	    0
// 1	1	    0	    =	    0

bool x = false;
bool y = true;

bool c = (!(x || y) == (!x && !y));
Console.WriteLine(c);
