#include "matrix.hpp"

Matrix::Matrix(Coordinate size) {
  if(size.x == 0 || size.y == 0) {
    //throw
  }
  width = size.x;
  height = size.y;
}

Matrix::~Matrix() {
  for(int i = 0; i < height; ++i) {
    for(int j = 0; j < width; ++j) {
      delete elements[i][j]; 
    }
  }
}
bool Matrix::create_empty_matrix() {
  for(int i = 0; i < height; ++i) {
   std::vector<MatrixElement*> column(width, new MatrixElement);
    for(int j = 0; j < width; ++j) {
      Coordinate coordinate;
      coordinate.x = j;
      coordinate.y = i;
      column[j]->set_coordinate(coordinate);
    }
    elements.push_back(column);
  }
  return true;
}
bool Matrix::fill_neighbours() {
  for(int i = 0; i < height; ++i) {
    for(int j = 0; j < width; ++j) {
      if(i != 0) {
        if(j != 0) {
          elements[i][j]->neighbours.push_back(elements[i - 1][j - 1]);
        }
        if(j < width - 1) {
          elements[i][j]->neighbours.push_back(elements[i - 1][j + 1]);
        }
        elements[i][j]->neighbours.push_back(elements[i - 1][j]);        
      }
      if(j != 0) {
        elements[i][j]->neighbours.push_back(elements[i][j - 1]);
      }
      if(j < width - 1) {
        elements[i][j]->neighbours.push_back(elements[i][j + 1]);
      }
      if(i < height - 1) {
        if(j != 0) {
          elements[i][j]->neighbours.push_back(elements[i + 1][j - 1]);
        }
        if(j < width - 1) {
          elements[i][j]->neighbours.push_back(elements[i + 1][j + 1]);
        }
        elements[i][j]->neighbours.push_back(elements[i + 1][j]);        
      }
    }
  }
  return true;
}

bool Matrix::init_empty_matrix() {
  return create_empty_matrix() && fill_neighbours();
}

int Matrix::count(){
  return width * height;
}

MatrixElement* Matrix::get_element(Coordinate element_co) {
  return elements[element_co.x][element_co.y];
}

bool MatrixElement::set_coordinate(Coordinate coordinate) {
  this->coordinate = coordinate;
  return true;
}

Coordinate MatrixElement::get_coordinate() {
  return coordinate;
}
