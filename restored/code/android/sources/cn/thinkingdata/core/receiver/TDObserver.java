package cn.thinkingdata.core.receiver;

import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public interface TDObserver {
    void onDataEnqueued(String str, JSONObject jSONObject);

    void onDistinctIdReceived(String str, String str2, String str3);

    void onLoginReceived(String str, String str2, String str3);

    void onLogoutReceived(String str, String str2);

    void onSdkInitReceived(String str);

    void onTimeCalibrated();
}
