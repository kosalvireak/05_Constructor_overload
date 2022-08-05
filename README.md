# 05_Constructor_overload
### Constructor overload is like method overload. We use it to instantiate different kinds of objects within the same class.
### It just need to has different parameters list.
```
class Name
{
  public Name(){              # No parameter
  }
  public Name(int num){       # 1 int parameter
  }
  public Name(string name){   # 1 string parameter
  }
}
```

### We can overload constructors in different ways as follows:
- By using different type of parameters
- By using different number of parameters
- By using different order of parameters
