package com.unicom.online.account.kernel;

import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkInfo;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes4.dex */
public final class x extends ConnectivityManager.NetworkCallback {
    public final /* synthetic */ ab b;

    public x(ab abVar) {
        this.b = abVar;
    }

    @Override // android.net.ConnectivityManager.NetworkCallback
    public final void onAvailable(Network network) {
        super.onAvailable(network);
        Thread.currentThread().getName();
        System.currentTimeMillis();
        ab abVar = this.b;
        abVar.b = network;
        abVar.b(true, network);
        try {
            ab abVar2 = this.b;
            NetworkInfo networkInfo = abVar2.d.getNetworkInfo(abVar2.b);
            if (networkInfo != null) {
                String extraInfo = networkInfo.getExtraInfo();
                if (TextUtils.isEmpty(extraInfo)) {
                    return;
                }
                String str = ao.b;
                as.b("APN:" + extraInfo);
                ao.t = extraInfo;
            }
        } catch (Exception e) {
            as.b(e);
        }
    }

    @Override // android.net.ConnectivityManager.NetworkCallback
    public final void onUnavailable() {
        super.onUnavailable();
        this.b.b(false, (Network) null);
        this.b.b();
    }
}
