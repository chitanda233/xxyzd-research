package com.kwad.sdk.mobileid.a.a;

import android.content.Context;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkRequest;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.service.ServiceProvider;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private ConnectivityManager aoN;
    private ConnectivityManager.NetworkCallback biZ;
    private volatile boolean bja = false;

    /* JADX INFO: renamed from: com.kwad.sdk.mobileid.a.a.a$a, reason: collision with other inner class name */
    public interface InterfaceC0533a {
        void Su();
    }

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.bja = true;
        return true;
    }

    public final void a(Context context, final InterfaceC0533a interfaceC0533a) {
        synchronized (this) {
            this.aoN = cE(context);
            try {
                NetworkRequest networkRequestBuild = new NetworkRequest.Builder().addTransportType(0).addCapability(12).build();
                if (this.biZ == null) {
                    this.biZ = new ConnectivityManager.NetworkCallback() { // from class: com.kwad.sdk.mobileid.a.a.a.1
                        @Override // android.net.ConnectivityManager.NetworkCallback
                        public final void onAvailable(Network network) {
                            a.this.aoN.bindProcessToNetwork(network);
                            if (interfaceC0533a != null && !a.this.bja) {
                                interfaceC0533a.Su();
                            }
                            a.a(a.this, true);
                        }

                        @Override // android.net.ConnectivityManager.NetworkCallback
                        public final void onUnavailable() {
                            a.this.aoN.bindProcessToNetwork(null);
                            c.d("MobileIdManager.RequestMobileDataOnWifiHelper", "onUnavailable unbindNetwork");
                            a.this.Sp();
                        }

                        @Override // android.net.ConnectivityManager.NetworkCallback
                        public final void onLost(Network network) {
                            a.this.aoN.bindProcessToNetwork(null);
                            c.d("MobileIdManager.RequestMobileDataOnWifiHelper", "onLost unbindNetwork");
                            a.this.Sp();
                        }
                    };
                }
                if (!this.bja) {
                    this.aoN.requestNetwork(networkRequestBuild, this.biZ);
                } else {
                    c.d("MobileIdManager.RequestMobileDataOnWifiHelper", "isRequestUaidToken is true unbindNetwork");
                    Sp();
                }
            } catch (Exception e) {
                ServiceProvider.reportSdkCaughtException(e);
            }
        }
    }

    public final void Sp() {
        synchronized (this) {
            if (this.biZ == null) {
                return;
            }
            try {
                ConnectivityManager connectivityManager = this.aoN;
                if (connectivityManager != null) {
                    connectivityManager.unregisterNetworkCallback(this.biZ);
                }
            } catch (Exception e) {
                ServiceProvider.reportSdkCaughtException(e);
            }
            this.aoN.bindProcessToNetwork(null);
            this.biZ = null;
        }
    }

    private static ConnectivityManager cE(Context context) {
        return (ConnectivityManager) context.getSystemService("connectivity");
    }
}
