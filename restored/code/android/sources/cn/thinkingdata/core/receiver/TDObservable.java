package cn.thinkingdata.core.receiver;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public interface TDObservable {
    void onDataEnqueued(String str, JSONObject jSONObject);

    void onLoginMethodCalled(String str, String str2, String str3);

    void onLogoutMethodCalled(String str, String str2);

    void onSdkInitCalled(String str);

    void onSetDistinctIdMethodCalled(String str, String str2, String str3);

    void onTimeCalibrated();

    void registerObserver(TDObserver tDObserver);

    void unregisterObserver(TDObserver tDObserver);
}
