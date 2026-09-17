package cn.thinkingdata.core.receiver;

import java.util.ArrayList;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDAnalyticsObservable implements TDObservable {
    private static volatile TDAnalyticsObservable instance;
    private final List<TDObserver> observers = new ArrayList();

    private TDAnalyticsObservable() {
    }

    public static TDAnalyticsObservable getInstance() {
        if (instance == null) {
            synchronized (TDAnalyticsObservable.class) {
                if (instance == null) {
                    instance = new TDAnalyticsObservable();
                }
            }
        }
        return instance;
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void onDataEnqueued(String str, JSONObject jSONObject) {
        synchronized (this) {
            for (TDObserver tDObserver : this.observers) {
                if (tDObserver != null) {
                    tDObserver.onDataEnqueued(str, jSONObject);
                }
            }
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void onLoginMethodCalled(String str, String str2, String str3) {
        synchronized (this) {
            for (TDObserver tDObserver : this.observers) {
                if (tDObserver != null) {
                    tDObserver.onLoginReceived(str, str2, str3);
                }
            }
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void onLogoutMethodCalled(String str, String str2) {
        synchronized (this) {
            for (TDObserver tDObserver : this.observers) {
                if (tDObserver != null) {
                    tDObserver.onLogoutReceived(str, str2);
                }
            }
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void onSdkInitCalled(String str) {
        synchronized (this) {
            for (TDObserver tDObserver : this.observers) {
                if (tDObserver != null) {
                    tDObserver.onSdkInitReceived(str);
                }
            }
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void onSetDistinctIdMethodCalled(String str, String str2, String str3) {
        synchronized (this) {
            for (TDObserver tDObserver : this.observers) {
                if (tDObserver != null) {
                    tDObserver.onDistinctIdReceived(str, str2, str3);
                }
            }
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void onTimeCalibrated() {
        synchronized (this) {
            for (TDObserver tDObserver : this.observers) {
                if (tDObserver != null) {
                    tDObserver.onTimeCalibrated();
                }
            }
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void registerObserver(TDObserver tDObserver) {
        synchronized (this) {
            this.observers.add(tDObserver);
        }
    }

    @Override // cn.thinkingdata.core.receiver.TDObservable
    public void unregisterObserver(TDObserver tDObserver) {
        synchronized (this) {
            this.observers.remove(tDObserver);
        }
    }
}
