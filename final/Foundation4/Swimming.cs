class Swimming : Activity {
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length) {
        this._laps = laps;
    }

    public override double GetDistance() {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed() {
        return GetDistance() / (_length / 60.0);
    }

    public override double GetPace() {
        return (_length / 60.0) / GetDistance();
    }

    public override string GetSummary() {
        return $"{base.GetSummary()} Swimming ({_length} min)- Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}