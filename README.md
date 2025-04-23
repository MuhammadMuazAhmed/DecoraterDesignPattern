#  Decorator Design Pattern in C#

This repository showcases a clean and easy-to-understand implementation of the **Decorator Design Pattern** in C#. The decorator pattern allows you to dynamically add new behavior or responsibilities to objects without altering their structure.

---

##  About the Code

This project focuses on enhancing a simple text message using various formatting styles such as **bold**, **italic**, **underline**, **font size**, and **color**. Each formatting style is implemented as a separate decorator class.

---

##  How It Works

- The `Textcomponent` abstract class defines the core interface for formatting.
- `Plaintext` is a concrete implementation of `Textcomponent` that holds the original message.
- Decorator classes (`Bold_decorator`, `Italic_decorator`, `Underline_decorator`, etc.) extend `Text_Decorator`, which itself extends `Textcomponent`.
- Each decorator adds its specific formatting to the base text dynamically.

---

##  Class Structure

| Class Name            | Responsibility                             |
|-----------------------|--------------------------------------------|
| `Textcomponent`       | Abstract base class for all text components |
| `Plaintext`           | Holds plain, unformatted text              |
| `Text_Decorator`      | Abstract decorator that wraps a component  |
| `Bold_decorator`      | Adds `*text*` bold formatting              |
| `Italic_decorator`    | Adds `_text_` italic formatting            |
| `Underline_decorator` | Adds `~text~` underline formatting         |
| `FontSizeDecorator`   | Adds `[size=16]text` style                 |
| `Color_decorator`     | Adds `[color=blue]text` style              |

---

##  UML Diagram

```plaintext
            +-------------------+
            |  Textcomponent    |<-----------------------------+
            +-------------------+                              |
                     ▲                                         |
                     |                                         |
          +---------------------+                   +------------------------+
          |     Plaintext       |                   |    Text_Decorator      |
          +---------------------+                   +------------------------+
                                                      ▲     ▲     ▲     ▲     ▲
                                                      |     |     |     |     |
                                              +------------+-------------+--------------+
                                              |            |             |              |
                                       Bold_  Italic_   Underline_   FontSize_   Color_
                                      decorator decorator decorator  Decorator  decorator

```
## ✨ Sample Usage

```csharp
Textcomponent text = new Plaintext("Hello");

Textcomponent decorated_text = new Bold_decorator(text);
Textcomponent decorated_text1 = new Underline_decorator(text);
Textcomponent decorated_text2 = new Italic_decorator(text);
Textcomponent decorated_text3 = new FontSizeDecorator(text, 16);
Textcomponent decorated_text4 = new Color_decorator(text, "blue");

Console.WriteLine(decorated_text.Format());     // *Hello*
Console.WriteLine(decorated_text1.Format());    // ~Hello~
Console.WriteLine(decorated_text2.Format());    // _Hello_
Console.WriteLine(decorated_text3.Format());    // [size=16]Hello
Console.WriteLine(decorated_text4.Format());    // [color=blue]Hello
