using System;
using System.Drawing;
namespace decorator
{
    public class Program{
        public static void Main(){
            Textcomponent text = new Plaintext ("Hello");
             Textcomponent decorated_text = new Bold_decorator(text);
             Textcomponent decorated_text1 = new Underline_decorator(text);
             Textcomponent decorated_text2 = new Italic_decorator(text);
             Textcomponent decorated_text3 = new FontSizeDecorator(text,16);
             Textcomponent decorated_text4 = new Color_decorator(text,"blue");
             Console.WriteLine(decorated_text.Format());
             Console.WriteLine(decorated_text1.Format());
             Console.WriteLine(decorated_text2.Format());
             Console.WriteLine(decorated_text3.Format());
             Console.WriteLine(decorated_text4.Format());
        }

    }

    public abstract class Textcomponent{
        public abstract string Format();
    }
    public class Plaintext:Textcomponent{
        private string _text;
        public Plaintext(string text){
            this._text = text;
        }
        public override string Format()
        {
            return _text;
        }

    }
    public abstract class Text_Decorator:Textcomponent{
        protected Textcomponent _textcomponent;
        public Text_Decorator(Textcomponent textcomponent){
            this._textcomponent = textcomponent;
        }
        public override string Format()
        {
            return _textcomponent.Format();
        }
    }
    public class Bold_decorator:Text_Decorator{
        public Bold_decorator(Textcomponent textcomponent):base(textcomponent){}
        public override string Format(){
            return "*" + _textcomponent.Format() + "*";
        }
    }
    public class Italic_decorator:Text_Decorator{
        public Italic_decorator(Textcomponent textcomponent):base(textcomponent){}
        public override string Format(){
            return "_" + _textcomponent.Format() + "_";
        }
    }
    public class Underline_decorator:Text_Decorator{
        public Underline_decorator(Textcomponent textcomponent):base(textcomponent){}
        public override string Format(){
            return "~" + _textcomponent.Format() + "~";
        }
    }
    public class FontSizeDecorator:Text_Decorator{
        private readonly int _fontSize;

    public FontSizeDecorator(Textcomponent textcomponent, int fontSize) : base(textcomponent)
    {
        _fontSize = fontSize;
    }
        public override string Format(){
             return $"[size={_fontSize}]" + _textcomponent.Format();
        }
    }
    public class Color_decorator:Text_Decorator{
        private readonly string _color;
        public Color_decorator(Textcomponent textcomponent,string color):base(textcomponent){
            _color = color;
        }
        public override string Format(){
             return $"[color={_color}]" + _textcomponent.Format();
        }
    }
}
