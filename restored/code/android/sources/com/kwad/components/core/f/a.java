package com.kwad.components.core.f;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.components.offline.api.IOfflineCompo;
import com.kwad.sdk.components.e;
import com.kwad.sdk.components.h;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.br;
import com.kwad.sdk.utils.bt;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends e implements h {
    private String RM;
    private long RN;
    private String RO;
    private Context mContext;

    @Override // com.kwad.sdk.components.e, com.kwad.sdk.components.b
    public final int priority() {
        return IOfflineCompo.Priority.HIGHEST;
    }

    @Override // com.kwad.sdk.components.b
    public final void init(Context context) {
        try {
            this.mContext = context;
            ao(context);
        } catch (Throwable th) {
            c.e("EncryptComponentsImpl", "initGId error : " + th);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void qO() {
        String strDq = ai.dq(this.mContext);
        String strWT = bt.WT();
        if (TextUtils.isEmpty(strDq)) {
            ai.ah(this.mContext, strWT);
            return;
        }
        if (TextUtils.equals(strDq, strWT)) {
            return;
        }
        this.RM = "";
        this.RN = 0L;
        this.RO = "";
        ai.ae(this.mContext, "");
        ai.d(this.mContext, this.RN);
        ai.ao(this.mContext, this.RO);
        ai.ah(this.mContext, strWT);
    }

    @Override // com.kwad.sdk.components.b
    public final Class getComponentsType() {
        return h.class;
    }

    private void ao(Context context) {
        c.i("EncryptComponentsImpl", "initGId");
        try {
            JSONObject jSONObject = new JSONObject();
            jSONObject.put("64", 0);
            if (com.kwad.sdk.core.config.e.a(com.kwad.sdk.core.config.c.aPQ)) {
                jSONObject.put("64_level", 1);
            }
            com.kwad.sdk.core.f.c.handlePolicy(jSONObject);
        } catch (Throwable th) {
            c.printStackTrace(th);
        }
        com.kwad.sdk.core.f.c.a(context, new com.kwad.sdk.core.f.a() { // from class: com.kwad.components.core.f.a.1
            @Override // com.kwad.sdk.core.f.a
            public final void au(String str) {
                c.d("initGId onSuccess", "deviceInfo：" + str);
                a.this.qO();
                a.this.as(str);
            }

            @Override // com.kwad.sdk.core.f.a
            public final void onFailed(int i, String str) {
                c.e("EncryptComponentsImpl", "initGId onFailed errorCode:" + i + "errorMessage :" + str);
            }
        });
    }

    @Override // com.kwad.sdk.components.h
    public final String qP() {
        return (com.kwad.sdk.core.config.e.JZ() || System.currentTimeMillis() >= qS() || TextUtils.isEmpty(qR())) ? qT() : "";
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void as(String str) {
        if (this.mContext == null || br.isNullString(str) || br.isEquals(qT(), str)) {
            return;
        }
        this.RO = str;
        ai.ao(this.mContext, str);
    }

    @Override // com.kwad.sdk.components.h
    public final void at(String str) {
        if (this.mContext == null || br.isNullString(str) || br.isEquals(qR(), str)) {
            return;
        }
        try {
            this.RM = str;
            ai.ae(this.mContext, str);
            com.kwad.sdk.core.f.c.setEgid(this.mContext, str);
        } catch (Throwable th) {
            c.e("EncryptComponentsImpl", "setEGid error : " + th);
        }
    }

    @Override // com.kwad.sdk.components.h
    public final void C(long j) {
        if (this.mContext == null || j <= 0 || j == qS()) {
            return;
        }
        this.RN = j;
        ai.d(this.mContext, j);
    }

    @Override // com.kwad.sdk.components.h
    public final com.kwad.sdk.core.a.h qQ() {
        return new com.kwad.sdk.core.a.a();
    }

    private String qR() {
        if (TextUtils.isEmpty(this.RM)) {
            this.RM = ai.dl(this.mContext);
        }
        return this.RM;
    }

    private long qS() {
        if (this.RN == 0) {
            this.RN = ai.m182do(this.mContext);
        }
        return this.RN;
    }

    private String qT() {
        if (TextUtils.isEmpty(this.RO)) {
            this.RO = ai.dt(this.mContext);
        }
        return this.RO;
    }
}
