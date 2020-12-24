interface IObserver{
   void Update(object update);
}

interface ISubject{
   void Attach(IObserver observer);
   void Detach(IObserver observer);
   void Notify();
}

class Subject: Isubject{
   private List<IObserver> _subjectObservers;

   public Subject(){
      _subjectObservers = new List<IObserver>();
   }

   void Attach(IObserver observer){
      _subjectObservers.Remove(observer);
   }

   void Notify(){
      foreach(var observer in _subjectObservers){
         observer.Update("some state");
      }
   }
}

class ObserverA: IObserver{
    void Update(object update){

    }
}

class ObserverB: IObserver{
    void Update(object update){

    }
}

class SomeClass{
    public void Init(){
        var observerA = new ObserverA();
        var observerB = new ObserverB();
        var subject = new Subject();
        subject.Attach(observerA);

    }
}
