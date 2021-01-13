#include <iostream>



class AbstractTable {
public:
    virtual ~AbstractTable() {};
    virtual std::string CreateTable() const = 0;
};


class ConcreteTableMetal : public AbstractTable {
public:
   
    std::string CreateTable() const override {
        return "The result of the product TableMetal";

    }
};

class ConcreteTableWood : public AbstractTable {
    std::string CreateTable() const override {
        return "The result of the product TableWood";
    }
};

class BuilderTable {
public:
    virtual ~BuilderTable() {};
    virtual ConcreteTableMetal* build() = 0;
    virtual void CreateLegs() const = 0;
    virtual void TableTop() const = 0;
    virtual void TableAssembly() const = 0;
};

class ConcreteBuilderTableMetal : public BuilderTable {
private:

    ConcreteTableMetal* product;

public:

    ConcreteBuilderTableMetal() {
        this->Reset();
    }

    ~ConcreteBuilderTableMetal() {
        delete product;
    }

    void Reset() {
        this->product = new ConcreteTableMetal();
    }

    void CreateLegs()const override {
        std::cout << "Metal Legs create\n";

    }

    void TableTop()const override {
        std::cout << "Metal Top create\n";
    }

    void TableAssembly()const override {
        std::cout << "Metal Table is assembled\n";
    }

    ConcreteTableMetal* build() { 
        ConcreteTableMetal* result = this->product; 
        this->Reset();
        return result;
    }
};

    class AbstractChair {

    public:
        virtual ~AbstractChair() {};
        virtual std::string CreateChair() const = 0;

    };


    class ConcreteChairMetal : public AbstractChair {

    public:
        std::string CreateChair() const override {
            return "The result of the product ChairMetal.";
        }

    };

    class ConcreteChairWood : public AbstractChair {

    public:
        std::string CreateChair() const override {
            return "The result of the product ChairWood.";
        }

    };


    class AbstractFactory {
    public:
        virtual AbstractTable* CreateTable() const = 0;
        virtual AbstractChair* CreateChair() const = 0;
    };

    class ConcreteFactoryMetal : public AbstractFactory {
    public:
        AbstractTable* CreateTable() const override {
            BuilderTable* builder = new ConcreteBuilderTableMetal();
            builder->CreateLegs();
            builder->TableTop();
            builder->TableAssembly();
            return builder->build();
        }
        AbstractChair* CreateChair() const override {
            return new ConcreteChairMetal();
        }
    };


    class ConcreteFactoryWood : public AbstractFactory {
    public:
        AbstractTable* CreateTable() const override {
            return new ConcreteTableWood();
        }
        AbstractChair* CreateChair() const override {
            return new ConcreteChairWood();
        }
    };


    int main() {
        ConcreteTableMetal* builder = new ConcreteTableMetal();
        std::cout << "Create product\n";
        ConcreteFactoryMetal* f1 = new ConcreteFactoryMetal();
        ConcreteFactoryWood* f2 = new ConcreteFactoryWood();
        const AbstractTable* product_a1 = f1->CreateTable();
        const AbstractChair* product_b1 = f1->CreateChair();
        const AbstractTable* product_a2 = f2->CreateTable();
        const AbstractChair* product_b2 = f2->CreateChair();
        std::cout << product_b1->CreateChair() << "\n";
        std::cout << product_a1->CreateTable() << "\n";
        std::cout << product_b2->CreateChair() << "\n";
        std::cout << product_a2->CreateTable() << "\n";

        return 0;
    }