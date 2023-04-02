class Activity {
    private DateTime _currentdate = DateTime.Today;
    public int _length; // in minutes

    public Activity(DateTime date, int length) {
        _currentdate = date;
        this._length = length;
    }

    public virtual double GetDistance() {
        return 0;
    }

    public virtual double GetSpeed() {
        return 0;
    }

    public virtual double GetPace() {
        return 0;
    }

    public virtual string GetSummary() {
        return $"{_currentdate.ToString("dd MMM yyyy")}";
    }
}