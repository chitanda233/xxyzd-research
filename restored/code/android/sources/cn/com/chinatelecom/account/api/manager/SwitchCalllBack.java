package cn.com.chinatelecom.account.api.manager;

import android.net.Network;

/* JADX INFO: loaded from: classes.dex */
public interface SwitchCalllBack {
    void onSwitchError(long j);

    void onSwitchSuccess(Network network, long j);

    void onSwitchTimeout();
}
