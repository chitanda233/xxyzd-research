package cn.thinkingdata.core.receiver;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkCapabilities;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes.dex */
public class TDNetWorkObservable {
    private static final int TYPE_ON_AVAILABLE = 1;
    private static final int TYPE_ON_CAPABILITIES_CHANGED = 3;
    private static final int TYPE_ON_CHANGE = 4;
    private static final int TYPE_ON_LOST = 2;
    private static volatile TDNetWorkObservable instance;
    private final CopyOnWriteArrayList<TDNetWorkObserver> observers = new CopyOnWriteArrayList<>();

    /* JADX INFO: renamed from: cn.thinkingdata.core.receiver.TDNetWorkObservable$2, reason: invalid class name */
    class AnonymousClass2 implements NetworkReceiver.ConnectivityListener {
        AnonymousClass2() {
        }

        @Override // cn.thinkingdata.core.receiver.NetworkReceiver.ConnectivityListener
        public void onChanged() {
            TDNetWorkObservable.this.notifyObservers(4, null, null);
        }
    }

    private TDNetWorkObservable(Context context) {
        registerNetWorkReceiver(context);
    }

    public static TDNetWorkObservable getInstance(Context context) {
        if (instance == null) {
            synchronized (TDAnalyticsObservable.class) {
                if (instance == null) {
                    instance = new TDNetWorkObservable(context);
                }
            }
        }
        return instance;
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void notifyObservers(int i, Network network, NetworkCapabilities networkCapabilities) {
        for (TDNetWorkObserver tDNetWorkObserver : this.observers) {
            if (tDNetWorkObserver != null) {
                if (i == 1) {
                    tDNetWorkObserver.onAvailable(network);
                } else if (i == 2) {
                    tDNetWorkObserver.onLost(network);
                } else if (i == 3) {
                    tDNetWorkObserver.onCapabilitiesChanged(network, networkCapabilities);
                } else if (i == 4) {
                    tDNetWorkObserver.onChange();
                }
            }
        }
    }

    private void registerNetWorkReceiver(Context context) {
        if (context == null) {
            return;
        }
        try {
            ((ConnectivityManager) context.getApplicationContext().getSystemService("connectivity")).registerDefaultNetworkCallback(new ConnectivityManager.NetworkCallback() { // from class: cn.thinkingdata.core.receiver.TDNetWorkObservable.1
                @Override // android.net.ConnectivityManager.NetworkCallback
                public void onAvailable(Network network) {
                    TDNetWorkObservable.this.notifyObservers(1, network, null);
                    super.onAvailable(network);
                }

                @Override // android.net.ConnectivityManager.NetworkCallback
                public void onCapabilitiesChanged(Network network, NetworkCapabilities networkCapabilities) {
                    TDNetWorkObservable.this.notifyObservers(3, network, networkCapabilities);
                    super.onCapabilitiesChanged(network, networkCapabilities);
                }

                @Override // android.net.ConnectivityManager.NetworkCallback
                public void onLost(Network network) {
                    TDNetWorkObservable.this.notifyObservers(2, network, null);
                    super.onLost(network);
                }
            });
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void addNetWorkObserver(TDNetWorkObserver tDNetWorkObserver) {
        this.observers.add(tDNetWorkObserver);
    }

    public void removeNetWorkObserver(TDNetWorkObserver tDNetWorkObserver) {
        this.observers.remove(tDNetWorkObserver);
    }
}
