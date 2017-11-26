main: main.cpp
	g++ -std=c++11 -stdlib=libc++ *.cpp -o main.out

test: unit_tests.cpp
	g++ -std=c++11 -stdlib=libc++ *.cpp -D TEST -o test.out

clean:
	rm *.out *.o
