package com.baidu.mobads.sdk.internal;

import android.text.TextUtils;
import com.baidu.mobads.sdk.api.CpuChannelResponse;
import com.baidu.mobads.sdk.api.IOAdEvent;
import java.util.List;
import java.util.Map;
import org.json.JSONArray;

/* JADX INFO: loaded from: classes.dex */
class q implements Runnable {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ IOAdEvent f515a;
    final /* synthetic */ p b;

    q(p pVar, IOAdEvent iOAdEvent) {
        this.b = pVar;
        this.f515a = iOAdEvent;
    }

    @Override // java.lang.Runnable
    public void run() {
        String str;
        IOAdEvent iOAdEvent = this.f515a;
        if (iOAdEvent == null || TextUtils.isEmpty(iOAdEvent.getType())) {
            return;
        }
        String type = this.f515a.getType();
        if (z.ar.equals(type)) {
            List<CpuChannelResponse> listA = n.a((JSONArray) this.f515a.getData().get("cpuChannelList"));
            if (this.b.f514a.t != null) {
                this.b.f514a.t.onChannelListLoaded(listA);
                return;
            }
            return;
        }
        if (z.as.equals(type)) {
            Map<String, Object> data = this.f515a.getData();
            int iIntValue = 0;
            if (data != null) {
                str = (String) data.get("error_message");
                Object obj = data.get("error_code");
                if (obj == null) {
                    obj = 0;
                }
                iIntValue = ((Integer) obj).intValue();
            } else {
                str = "";
            }
            if (this.b.f514a.t != null) {
                this.b.f514a.t.onChannelListError(str, iIntValue);
            }
        }
    }
}
