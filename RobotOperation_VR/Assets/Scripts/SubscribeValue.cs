using System;

public class SubscribeValue<T>
{
    public event Action<T> Subscribe;
    private T _value;

    public SubscribeValue()
    {
        _value = default;
    }

    public SubscribeValue(T defaultValue)
    {
        _value = defaultValue;
    }

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            Subscribe?.Invoke(_value);
        }
    }
}

public class SubscribeValue<T,U>
{
    public event Action<T,U> Subscribe;
    private T _value;
    private U _value2;

    public SubscribeValue()
    {
        _value = default;
        _value2 = default;
    }

    public SubscribeValue(T defaultValue,U defaultValue2)
    {
        _value = defaultValue;
        _value2 = defaultValue2;
    }

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            Subscribe?.Invoke(_value,_value2);
        }
    }
}
