package com.unicom.online.account.kernel;

import com.unicom.online.account.shield.ResultListener;
import com.unicom.online.account.shield.UniAccountHelper;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class bk implements ResultListener {
    public final /* synthetic */ int b;
    public final /* synthetic */ ResultListener c;
    public final /* synthetic */ int d;
    public final /* synthetic */ int e;
    public final /* synthetic */ UniAccountHelper f;

    public bk(UniAccountHelper uniAccountHelper, int i, int i2, int i3, ResultListener resultListener) {
        this.f = uniAccountHelper;
        this.b = i;
        this.c = resultListener;
        this.d = i2;
        this.e = i3;
    }

    @Override // com.unicom.online.account.shield.ResultListener
    public final void onResult(String str) {
        try {
            int i = l.d;
            if (i > 5) {
                l.d = 4;
            } else if (i >= 1) {
                l.d = i - 1;
            } else {
                l.d = 0;
            }
            JSONObject jSONObject = new JSONObject(str);
            jSONObject.optString("seq");
            int i2 = jSONObject.getInt("resultCode");
            jSONObject.put("type", this.b);
            if (i2 == 100) {
                l.b();
                this.c.onResult(str);
                return;
            }
            int i3 = l.d;
            if (i3 == 0) {
                l.b();
                this.c.onResult(str);
            } else if (i3 > 0) {
                try {
                    Thread.sleep(200L);
                    this.f.cuGetTokenUaidLoopCommon(this.d, this.b, this.e, this.c);
                } catch (InterruptedException unused) {
                    Thread.currentThread().interrupt();
                }
            }
        } catch (JSONException e) {
            l.b();
            if (ar.b) {
                e.printStackTrace();
            }
        }
    }
}
