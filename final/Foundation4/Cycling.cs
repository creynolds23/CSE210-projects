class Cycling : Activity {
    private double _speed; // in mph

    public Cycling(DateTime date, int length, double speed) : base(date, length) {
        this._speed = speed;
    }

    public override double GetSpeed() {
        return _speed;
    }

    public override double GetDistance() {
        return _speed * (_length / 60.0);
    }

    public override double GetPace() {
        return 60.0 / _speed;
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} Cycling ({_length} min)- Distance {GetDistance():F1} miles, Speed: {_speed:F1} mph, Pace: {GetPace():F1} min per mile";
    }
}