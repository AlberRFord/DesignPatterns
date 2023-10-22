#include <iostream>
using namespace std;

class Square {

protected:
    int width = 0, length = 0;

public:
    Square() { setWidth(0); setLength(0); }
    Square(int w, int l) {
        setWidth(w); 
        setLength(l);
    }

    int getLength() { return length; }
    int getWidth() { return width; }
    void setLength(int l) { length = l; }
    void setWidth(int w) { width = w; }

};

class Circle {

protected:
    int radius;

public:
    Circle() { setRadius(0); }
    Circle(int r) { setRadius(r); }
    int getRadius() { return radius; }
    void setRadius(int rad) {
        this->radius = rad;
    }
};

class adapterCircleToBody : public Circle, public Square{

public:
    adapterCircleToBody(Circle r) {
        setLength(r.getRadius());
        setWidth(r.getRadius());
    }
};

int main()
{
    Square body1(5, 6);
    Circle circle1(5);
    cout << "Body Length: " << body1.getLength() << endl;
    cout << "Body Width: " << body1.getWidth() << endl;
    cout << endl;
    cout << "Circle Radius: " << circle1.getRadius() << endl;
    cout << endl;
    adapterCircleToBody adCTB1(circle1);
    cout << "Transformed to Square Circle Length: " << adCTB1.getLength() << endl;
    cout << "Transformed to Square Circle Width: " << adCTB1.getWidth() << endl;

}

