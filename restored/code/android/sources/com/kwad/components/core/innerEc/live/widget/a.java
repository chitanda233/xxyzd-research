package com.kwad.components.core.innerEc.live.widget;

import java.util.Observable;
import java.util.Observer;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class a<T> extends Observable {
    private T Yh;
    private final CopyOnWriteArrayList<Observer> Yi = new CopyOnWriteArrayList<>();
    private boolean Yj = false;
    private Throwable Yk = null;

    private a(T t) {
        this.Yh = t;
    }

    public static <T> a<T> h(T t) {
        return new a<>(null);
    }

    public final void onNext(T t) {
        if (this.Yj || this.Yk != null) {
            return;
        }
        this.Yh = t;
        setChanged();
        notifyObservers(t);
    }

    @Override // java.util.Observable
    public final void addObserver(Observer observer) {
        if (!this.Yj && this.Yk == null) {
            this.Yi.add(observer);
            super.addObserver(observer);
            observer.update(this, this.Yh);
        }
    }
}
