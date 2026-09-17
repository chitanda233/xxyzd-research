package cn.thinkingdata.core.receiver;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;

/* JADX INFO: loaded from: classes.dex */
public class NetworkReceiver extends BroadcastReceiver {
    private ConnectivityListener listener;

    public interface ConnectivityListener {
        void onChanged();
    }

    public NetworkReceiver(ConnectivityListener connectivityListener) {
        setListener(connectivityListener);
    }

    @Override // android.content.BroadcastReceiver
    public void onReceive(Context context, Intent intent) {
        ConnectivityListener connectivityListener;
        if (!intent.getAction().equals("android.net.conn.CONNECTIVITY_CHANGE") || (connectivityListener = this.listener) == null) {
            return;
        }
        connectivityListener.onChanged();
    }

    public void setListener(ConnectivityListener connectivityListener) {
        this.listener = connectivityListener;
    }
}
