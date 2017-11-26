#ifndef TEST

#include <iostream>
#include "matrix.hpp"

int main() {
  Coordinate coordinate;
  coordinate.x = 4;
  coordinate.y = 4;
  Matrix* matrix = new Matrix(coordinate);
  matrix->init_empty_matrix();
  return 0;
}

#endif
