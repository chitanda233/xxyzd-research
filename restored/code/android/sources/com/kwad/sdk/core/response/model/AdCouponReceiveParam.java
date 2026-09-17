package com.kwad.sdk.core.response.model;

import android.text.TextUtils;
import com.kwad.sdk.utils.ac;
import com.sigmob.sdk.base.n;
import java.io.Serializable;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class AdCouponReceiveParam extends com.kwad.sdk.core.response.a.a implements Serializable {
    private static final long serialVersionUID = 3401922564904240855L;
    public String ext = "";
    public int flowType;
    public String receiveFailToast;
    public String receiveToast;
    public String sign;

    public boolean isEmpty() {
        return TextUtils.isEmpty(this.sign) || this.flowType == 0;
    }

    @Override // com.kwad.sdk.core.response.a.a
    public void afterToJson(JSONObject jSONObject) {
        super.afterToJson(jSONObject);
        ac.putValue(jSONObject, "receiveToast", this.receiveToast);
        ac.putValue(jSONObject, "sign", this.sign);
        ac.putValue(jSONObject, n.m, this.ext);
        ac.putValue(jSONObject, "receiveFailToast", this.receiveFailToast);
        ac.putValue(jSONObject, "flowType", this.flowType);
    }
}
