package com.byazt.eia;

import android.content.Context;
import com.byazt.ete.hq;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.ls.tt
@com.byazt.zqa.c(c = {0, 1, 1048, 15})
public class uj implements c, da {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    @com.byazt.ls.c(c = com.sigmob.sdk.base.n.m)
    public String f851a;

    @com.byazt.ls.c(c = "path", tt = "DSL")
    public String c;

    @com.byazt.ls.c(c = "landing_page_source")
    public int da;

    @com.byazt.ls.c(c = "event_tag")
    public String i;

    @com.byazt.ls.c(c = PointCategory.TARGET_URL)
    public String n;

    @com.byazt.ls.c(c = "context")
    public Context sp;

    @com.byazt.ls.c(c = com.alipay.sdk.m.n.c.e, tt = "DSL")
    public String tt;

    @com.byazt.ls.c(c = "wc_miniapp_info")
    public JSONObject uj;

    @com.byazt.ls.c(c = "type", tt = "DSL")
    public int ve;

    @com.byazt.ls.c(c = "convert_from_landing_page")
    public boolean x;

    public Context getContext() {
        return this.sp;
    }

    public boolean tt() {
        return this.x;
    }

    public String ve() {
        return this.i;
    }

    public int uj() {
        return this.da;
    }

    @Override // com.byazt.eia.da
    public hq A_() {
        return hq.c(this.uj);
    }

    public String sp() {
        return this.c;
    }

    public String i() {
        return this.tt;
    }

    @Override // com.byazt.eia.da
    public String x() {
        return this.n;
    }

    @Override // com.byazt.eia.da
    public String w_() {
        return this.f851a;
    }

    public int da() {
        return this.ve;
    }

    @Override // com.byazt.eia.c
    public Map<String, String> c() {
        return new HashMap();
    }
}
