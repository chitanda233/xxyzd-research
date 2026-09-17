package com.kwai.adclient.kscommerciallogger.model;

import android.text.TextUtils;
import com.kwad.components.offline.api.core.api.ILoggerReporter;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private final d aJT;
    private final BusinessType biz;
    private final String category;
    private final String eventId;
    private final JSONObject extraParam;
    private final JSONObject msg;
    private final SubBusinessType subBiz;
    private final String tag;

    /* synthetic */ c(a aVar, byte b) {
        this(aVar);
    }

    private c(a aVar) {
        this.category = aVar.buM;
        this.biz = aVar.buN;
        this.subBiz = aVar.buO;
        this.tag = aVar.mTag;
        this.aJT = aVar.buP;
        this.extraParam = aVar.buQ;
        this.eventId = aVar.buR;
        this.msg = aVar.msg == null ? new JSONObject() : aVar.msg;
    }

    public final String Yo() {
        return this.category;
    }

    public final SubBusinessType Yp() {
        return this.subBiz;
    }

    public final d Yq() {
        return this.aJT;
    }

    public final JSONObject Yr() {
        return this.msg;
    }

    public final JSONObject Ys() {
        return this.extraParam;
    }

    public final String Yt() {
        return this.eventId;
    }

    public final String toString() {
        JSONObject jSONObject = new JSONObject();
        try {
            BusinessType businessType = this.biz;
            if (businessType != null) {
                jSONObject.put(com.alipay.sdk.m.m.b.l, businessType.value);
            }
            SubBusinessType subBusinessType = this.subBiz;
            if (subBusinessType != null) {
                jSONObject.put("sub_biz", subBusinessType.value);
            }
            jSONObject.put("tag", this.tag);
            d dVar = this.aJT;
            if (dVar != null) {
                jSONObject.put("type", dVar.getValue());
            }
            JSONObject jSONObject2 = this.msg;
            if (jSONObject2 != null) {
                jSONObject.put("msg", jSONObject2);
            }
            JSONObject jSONObject3 = this.extraParam;
            if (jSONObject3 != null) {
                jSONObject.put("extra_param", jSONObject3);
            }
            jSONObject.put("event_id", this.eventId);
        } catch (JSONException e) {
            e.printStackTrace();
        }
        return jSONObject.toString();
    }

    public static class a {
        private final String buM;
        private BusinessType buN;
        private SubBusinessType buO;
        private d buP;
        private JSONObject buQ;
        private String buR;
        private String mTag;
        private JSONObject msg;

        private a(String str) {
            this.buM = str;
        }

        public static a Yu() {
            return new a(ILoggerReporter.Category.ERROR_LOG);
        }

        public static a Yv() {
            return new a(ILoggerReporter.Category.APM_LOG);
        }

        public final a c(BusinessType businessType) {
            this.buN = businessType;
            return this;
        }

        public final a b(SubBusinessType subBusinessType) {
            this.buO = subBusinessType;
            return this;
        }

        public final a iD(String str) {
            this.mTag = str;
            return this;
        }

        public final a b(d dVar) {
            this.buP = dVar;
            return this;
        }

        public final a iE(String str) {
            this.buR = str;
            return this;
        }

        public final a B(JSONObject jSONObject) {
            this.msg = jSONObject;
            return this;
        }

        public final c Yw() {
            if (com.kwai.adclient.kscommerciallogger.a.Yl().isDebug()) {
                if (TextUtils.isEmpty(this.buM) || TextUtils.isEmpty(this.mTag) || TextUtils.isEmpty(this.buR)) {
                    throw new IllegalArgumentException("param is error, please check it");
                }
                if (com.kwai.adclient.kscommerciallogger.a.Yl().Yn() && !com.kwai.adclient.kscommerciallogger.b.iC(this.buR)) {
                    throw new IllegalArgumentException("event_id format error, please check it");
                }
            } else {
                if (TextUtils.isEmpty(this.buM) || TextUtils.isEmpty(this.mTag) || TextUtils.isEmpty(this.buR)) {
                    return null;
                }
                if (com.kwai.adclient.kscommerciallogger.a.Yl().Yn() && !com.kwai.adclient.kscommerciallogger.b.iC(this.buR)) {
                    return null;
                }
            }
            if (com.kwai.adclient.kscommerciallogger.a.Yl().Ym() != null) {
                this.buQ = com.kwai.adclient.kscommerciallogger.a.Yl().Ym();
            }
            return new c(this, (byte) 0);
        }
    }
}
