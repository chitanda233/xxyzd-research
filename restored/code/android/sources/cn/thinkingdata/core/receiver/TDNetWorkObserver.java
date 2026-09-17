package cn.thinkingdata.core.receiver;

import android.net.Network;
import android.net.NetworkCapabilities;

/* JADX INFO: loaded from: classes.dex */
public interface TDNetWorkObserver {
    void onAvailable(Network network);

    void onCapabilitiesChanged(Network network, NetworkCapabilities networkCapabilities);

    void onChange();

    void onLost(Network network);
}
