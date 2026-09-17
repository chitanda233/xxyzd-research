package com.kwad.sdk.core.response.model;

import android.text.TextUtils;
import com.alipay.sdk.m.y.o;
import com.byazt.bv.BaseConstants;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kwad.sdk.components.d;
import com.kwad.sdk.components.h;
import com.kwad.sdk.core.a.e;
import com.kwad.sdk.core.response.helper.f;
import com.kwad.sdk.utils.ac;
import com.kwad.sdk.utils.br;
import java.io.Serializable;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public abstract class BaseResultData implements com.kwad.sdk.core.b, Serializable {
    private static final int CODE_RESULT_OK = 1;
    private static final long serialVersionUID = -8657363515914699792L;
    public String cookie;
    public String errorMsg;
    public String extra;
    public boolean hasAd;
    public long llsid;
    public int result;
    public String testErrorMsg;

    public boolean isDataEmpty() {
        return false;
    }

    public boolean notifyFailOnResultError() {
        return true;
    }

    @Override // com.kwad.sdk.core.b
    public void parseJson(JSONObject jSONObject) {
        if (jSONObject == null) {
            return;
        }
        this.llsid = jSONObject.optLong("llsid");
        this.result = jSONObject.optInt(o.c);
        this.hasAd = jSONObject.optBoolean("hasAd");
        this.errorMsg = jSONObject.optString(MediationConstant.KEY_ERROR_MSG);
        this.testErrorMsg = jSONObject.optString("testErrorMsg");
        String strOptString = jSONObject.optString(BaseConstants.EVENT_LABEL_EXTRA);
        if (!br.isNullString(strOptString)) {
            this.extra = ((e) d.f(e.class)).getResponseData(strOptString);
        }
        h hVar = (h) d.f(h.class);
        if (hVar != null) {
            hVar.at(jSONObject.optString("egid"));
            hVar.C(jSONObject.optLong("gidExpireTimeMs"));
        }
        String strOptString2 = jSONObject.optString("cookie");
        this.cookie = strOptString2;
        if (TextUtils.isEmpty(strOptString2)) {
            return;
        }
        f.NJ().fl(this.cookie);
    }

    @Override // com.kwad.sdk.core.b
    public JSONObject toJson() {
        return baseToJson();
    }

    public JSONObject baseToJson() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, "llsid", this.llsid);
        ac.putValue(jSONObject, BaseConstants.EVENT_LABEL_EXTRA, this.extra);
        ac.putValue(jSONObject, o.c, this.result);
        ac.putValue(jSONObject, "hasAd", this.hasAd);
        ac.putValue(jSONObject, MediationConstant.KEY_ERROR_MSG, this.errorMsg);
        ac.putValue(jSONObject, "testErrorMsg", this.testErrorMsg);
        ac.putValue(jSONObject, "cookie", this.cookie);
        return jSONObject;
    }

    public boolean isResultOk() {
        return this.result == 1;
    }

    public boolean hasData() {
        return this.hasAd;
    }
}
