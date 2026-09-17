package cn.com.chinatelecom.account.api.external.manager;

import android.net.Network;

/* JADX INFO: loaded from: classes.dex */
public interface SwitchCalllBackExternal {
    void onSwitchError(long j);

    void onSwitchSuccess(Network network, long j);

    void onSwitchTimeout();
}
