#ifndef MATRIX_HPP
#define MATRIX_HPP

#include <iostream>
#include <vector>

class Coordinate {
  public:
    int x;
    int y;
};

class MatrixElement {
  private:
    int value;
    Coordinate coordinate;    
  public:
    std::vector<MatrixElement *> neighbours;
    bool set_coordinate(Coordinate);
    Coordinate get_coordinate();
    bool set_value(int value);
    int get_value();
};

class Matrix {
  private:
    std::vector<std::vector<MatrixElement*>> elements;
    int width;
    int height;
  public:
    bool init_empty_matrix();
    Matrix(Coordinate size);
    ~Matrix();
    int count();
    MatrixElement* get_element(Coordinate);
    bool create_empty_matrix();
    bool fill_neighbours();
    bool set(Coordinate, MatrixElement);
};


#endif
