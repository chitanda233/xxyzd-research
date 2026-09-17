package com.cmic.gen.sdk.f;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkRequest;

/* JADX INFO: compiled from: WifiNetworkUtils.java */
/* JADX INFO: loaded from: classes2.dex */
public class s {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static s f2134a;
    private ConnectivityManager b;

    /* JADX INFO: compiled from: WifiNetworkUtils.java */
    public interface a {
        void a(Network network, ConnectivityManager.NetworkCallback networkCallback);
    }

    private s(Context context) {
        try {
            this.b = (ConnectivityManager) context.getSystemService("connectivity");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public static s a(Context context) {
        if (f2134a == null) {
            synchronized (s.class) {
                if (f2134a == null) {
                    f2134a = new s(context);
                }
            }
        }
        return f2134a;
    }

    public synchronized void a(final a aVar) {
        try {
            if (this.b == null) {
                c.a("WifiNetworkUtils", "mConnectivityManager 为空");
                aVar.a(null, null);
                return;
            }
            NetworkRequest networkRequestBuild = new NetworkRequest.Builder().addCapability(12).addTransportType(0).build();
            ConnectivityManager.NetworkCallback networkCallback = new ConnectivityManager.NetworkCallback() { // from class: com.cmic.gen.sdk.f.s.1
                @Override // android.net.ConnectivityManager.NetworkCallback
                public void onAvailable(Network network) {
                    try {
                        if (s.this.b.getNetworkCapabilities(network).hasTransport(0)) {
                            aVar.a(network, this);
                        } else {
                            c.a("WifiNetworkUtils", "切换失败，未开启数据网络");
                            aVar.a(null, this);
                        }
                    } catch (Exception e) {
                        e.printStackTrace();
                        aVar.a(null, this);
                    }
                }
            };
            try {
                this.b.requestNetwork(networkRequestBuild, networkCallback);
            } catch (Exception e) {
                e.printStackTrace();
                aVar.a(null, networkCallback);
            }
        } catch (Throwable th) {
            throw th;
        }
    }

    public void a(ConnectivityManager.NetworkCallback networkCallback) {
        if (this.b == null || networkCallback == null) {
            return;
        }
        try {
            c.b("WifiNetworkUtils", "unregisterNetworkCallback");
            this.b.unregisterNetworkCallback(networkCallback);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
