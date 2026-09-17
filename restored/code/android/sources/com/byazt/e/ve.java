package com.byazt.e;

import android.text.TextUtils;
import com.byazt.bv.BaseConstants;
import com.byazt.gq.t;
import com.sigmob.sdk.base.mta.PointParamKey;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 443, 54})
public class ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final String f821a;
    public String c;
    public final List<String> da;
    public final JSONObject i;
    public final JSONObject m;
    public final long n;
    public final int sl;
    public final long sp;
    public final Object t;
    public final String tt;
    public final String u;
    public final boolean uj;
    public final String ve;
    public final JSONObject x;
    public final boolean yp;
    public final String z;

    public ve(c cVar) {
        this.c = cVar.c;
        this.tt = cVar.tt;
        this.ve = cVar.ve;
        this.uj = cVar.uj;
        this.n = cVar.n;
        this.f821a = cVar.f822a;
        this.sp = cVar.sp;
        this.x = cVar.x;
        this.i = cVar.i;
        this.da = cVar.sl;
        this.sl = cVar.t;
        this.t = cVar.u;
        this.yp = cVar.z;
        this.z = cVar.m;
        this.m = cVar.nu;
        this.u = cVar.yp;
    }

    @com.byazt.zqa.c(c = {0, 1, 443, 24})
    public static class c {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        public String f822a;
        public String c;
        public Map<String, Object> da;
        public JSONObject i;
        public String m;
        public long n;
        public JSONObject nu;
        public List<String> sl;
        public long sp;
        public int t;
        public String tt;
        public Object u;
        public String ve;
        public JSONObject x;
        public String yp;
        public boolean uj = false;
        public boolean z = false;

        public c c(boolean z) {
            this.z = z;
            return this;
        }

        public c c(String str) {
            this.tt = str;
            return this;
        }

        public c tt(String str) {
            this.ve = str;
            return this;
        }

        public c c(long j) {
            this.n = j;
            return this;
        }

        public c tt(long j) {
            this.sp = j;
            return this;
        }

        public c ve(String str) {
            this.f822a = str;
            return this;
        }

        public c tt(boolean z) {
            this.uj = z;
            return this;
        }

        public c c(JSONObject jSONObject) {
            this.x = jSONObject;
            return this;
        }

        public c tt(JSONObject jSONObject) {
            this.i = jSONObject;
            return this;
        }

        public c c(List<String> list) {
            this.sl = list;
            return this;
        }

        public c c(int i) {
            this.t = i;
            return this;
        }

        public c c(Object obj) {
            this.u = obj;
            return this;
        }

        public c uj(String str) {
            this.yp = str;
            return this;
        }

        public ve c() {
            if (TextUtils.isEmpty(this.c)) {
                this.c = BaseConstants.CATEGORY_UMENG;
            }
            JSONObject jSONObject = new JSONObject();
            if (this.x == null) {
                this.x = new JSONObject();
            }
            try {
                Map<String, Object> map = this.da;
                if (map != null && !map.isEmpty()) {
                    for (Map.Entry<String, Object> entry : this.da.entrySet()) {
                        if (!this.x.has(entry.getKey())) {
                            this.x.putOpt(entry.getKey(), entry.getValue());
                        }
                    }
                }
                if (this.z) {
                    this.m = this.ve;
                    JSONObject jSONObject2 = new JSONObject();
                    this.nu = jSONObject2;
                    if (this.uj) {
                        jSONObject2.put(BaseConstants.EVENT_LABEL_AD_EXTRA_DATA, this.x.toString());
                    } else {
                        Iterator<String> itKeys = this.x.keys();
                        while (itKeys.hasNext()) {
                            String next = itKeys.next();
                            this.nu.put(next, this.x.get(next));
                        }
                    }
                    this.nu.put(PointParamKey.CATEGORY, this.c);
                    this.nu.put("tag", this.tt);
                    this.nu.put("value", this.n);
                    this.nu.put("ext_value", this.sp);
                    if (!TextUtils.isEmpty(this.yp)) {
                        this.nu.put("refer", this.yp);
                    }
                    JSONObject jSONObject3 = this.i;
                    if (jSONObject3 != null) {
                        this.nu = com.byazt.ki.tt.c(jSONObject3, this.nu);
                    }
                    if (this.uj) {
                        if (!this.nu.has("log_extra") && !TextUtils.isEmpty(this.f822a)) {
                            this.nu.put("log_extra", this.f822a);
                        }
                        this.nu.put(BaseConstants.EVENT_LABEL_IS_AD_EVENT, "1");
                    }
                }
                if (this.uj) {
                    jSONObject.put(BaseConstants.EVENT_LABEL_AD_EXTRA_DATA, this.x.toString());
                    if (!jSONObject.has("log_extra") && !TextUtils.isEmpty(this.f822a)) {
                        jSONObject.put("log_extra", this.f822a);
                    }
                    jSONObject.put(BaseConstants.EVENT_LABEL_IS_AD_EVENT, "1");
                } else {
                    jSONObject.put(BaseConstants.EVENT_LABEL_EXTRA, this.x);
                }
                if (!TextUtils.isEmpty(this.yp)) {
                    jSONObject.putOpt("refer", this.yp);
                }
                JSONObject jSONObject4 = this.i;
                if (jSONObject4 != null) {
                    jSONObject = com.byazt.ki.tt.c(jSONObject4, jSONObject);
                }
                this.x = jSONObject;
            } catch (Exception e) {
                t.gt().c(e, "DownloadEventModel build");
            }
            return new ve(this);
        }
    }

    public String c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public String ve() {
        return this.ve;
    }

    public boolean uj() {
        return this.uj;
    }

    public long n() {
        return this.n;
    }

    public String a() {
        return this.f821a;
    }

    public long sp() {
        return this.sp;
    }

    public JSONObject x() {
        return this.x;
    }

    public JSONObject i() {
        return this.i;
    }

    public List<String> da() {
        return this.da;
    }

    public int sl() {
        return this.sl;
    }

    public Object t() {
        return this.t;
    }

    public boolean u() {
        return this.yp;
    }

    public String yp() {
        return this.z;
    }

    public JSONObject z() {
        return this.m;
    }

    public String toString() {
        StringBuilder sbAppend = new StringBuilder("category: ").append(this.c).append("\ttag: ").append(this.tt).append("\tlabel: ").append(this.ve).append("\nisAd: ").append(this.uj).append("\tadId: ").append(this.n).append("\tlogExtra: ").append(this.f821a).append("\textValue: ").append(this.sp).append("\nextJson: ").append(this.x).append("\nparamsJson: ").append(this.i).append("\nclickTrackUrl: ");
        List<String> list = this.da;
        StringBuilder sbAppend2 = sbAppend.append(list != null ? list.toString() : "").append("\teventSource: ").append(this.sl).append("\textraObject: ");
        Object obj = this.t;
        StringBuilder sbAppend3 = sbAppend2.append(obj != null ? obj.toString() : "").append("\nisV3: ").append(this.yp).append("\tV3EventName: ").append(this.z).append("\tV3EventParams: ");
        JSONObject jSONObject = this.m;
        return sbAppend3.append(jSONObject != null ? jSONObject.toString() : "").toString();
    }
}
