#ifdef TEST

#include <iostream>
#define CATCH_CONFIG_MAIN
#include "catch.hpp"
#include "matrix.hpp"


TEST_CASE("Coordinates assigned", "[Coordinate]") {
  Coordinate coordinates;
  coordinates.x = 4;
  coordinates.y = 5;
  REQUIRE(coordinates.x == 4);
  REQUIRE(coordinates.y == 5);
}

TEST_CASE("Matrix not null", "[Matrix]") {
  Coordinate coordinates;
  coordinates.x = 4;
  coordinates.y = 5;
  Matrix* matrix = new Matrix(coordinates);
  REQUIRE(matrix != nullptr);
}

TEST_CASE("Empty elements pushed", "[Matrix]") {
  Coordinate coordinates;
  coordinates.x = 4;
  coordinates.y = 5;
  Matrix* matrix = new Matrix(coordinates);
  matrix->create_empty_matrix();
  REQUIRE(matrix->count() == (4 * 5));
}

TEST_CASE("Geting a matrix element, and it is not nullptr" "[GetElement]") {
  Coordinate size;
  size.x = 4;
  size.y = 5;
  Matrix* matrix = new Matrix(size);
  matrix->create_empty_matrix();
  Coordinate element_co;
  element_co.x = 3;
  element_co.y = 3;
  MatrixElement* element = matrix->get_element(element_co);
  REQUIRE(element != nullptr);
}

TEST_CASE("Matrix element coordinates are filled" "[MatrixElements]") {
  Coordinate size;
  size.x = 4;
  size.y = 5;
  Matrix* matrix = new Matrix(size);
  matrix->create_empty_matrix();
  Coordinate element_co;
  element_co.x = 3;
  element_co.y = 3;
  MatrixElement* element = matrix->get_element(element_co);
  Coordinate getted_coordinate = element->get_coordinate();
  std::cout << std::to_string(getted_coordinate.x) << " " << std::to_string(getted_coordinate.y) << std::endl;  
  REQUIRE(getted_coordinate.x == element_co.x);
  REQUIRE(getted_coordinate.y == element_co.y);
}

TEST_CASE("3,3 has 8 neighbours" "[Neighbours]") {
  Coordinate size;
  size.x = 4;
  size.y = 5;
  Matrix* matrix = new Matrix(size);
  matrix->create_empty_matrix();
  matrix->fill_neighbours();  
  Coordinate element_co;
  element_co.x = 0;
  element_co.y = 0;
  MatrixElement* element = matrix->get_element(element_co);
  Coordinate getted_coordinate = element->get_coordinate();
  std::cout << std::to_string(getted_coordinate.x) << " " << std::to_string(getted_coordinate.y) << std::endl;
  REQUIRE(element->neighbours.size() == 8);
}

#endif
