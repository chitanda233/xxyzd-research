package com.byazt.bp;

import android.content.Context;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.text.TextUtils;
import com.byazt.nr.m;
import com.byazt.nr.sp;
import com.byazt.px.n;
import com.byazt.vx.gu;
import com.byazt.vx.my;
import com.byazt.yf.a;
import com.byazt.yf.yp;
import com.byazt.yxi.uj;
import com.bykv.vk.openvk.api.proto.PluginValueSet;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import java.io.File;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.concurrent.ConcurrentHashMap;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 896, 20})
public class c {
    public static final c aw = new c();
    public final Map<String, Integer> bx;
    public String d;
    public String da;
    public com.byazt.ko.c eo;
    public boolean gr;
    public List<String> gu;
    public boolean h;
    public yp hd;
    public boolean i;
    public int[] ic;
    public boolean md;
    public a my;
    public Object nb;
    public PluginValueSet or;
    public String p;
    public long pf;
    public com.byazt.xf.ve qp;
    public Map<String, String> sl;
    public final Map<String, Float> sv;
    public String t;
    public String[] tt;
    public String u;
    public String uj;
    public String ve;
    public String x;
    public boolean yv;
    public boolean zb;
    public JSONObject zm;
    public int c = 0;
    public boolean n = true;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public boolean f706a = false;
    public boolean sp = false;
    public Set<String> yp = new HashSet();
    public Map<String, Map<String, String>> z = new HashMap();
    public Map<String, Map<String, String>> m = new HashMap();
    public boolean nu = false;
    public final Map<String, Object> rh = new my();
    public long gt = -1;
    public Map<String, Object> rl = new ConcurrentHashMap();
    public Map<String, Object> qy = new ConcurrentHashMap();
    public int cu = -1;

    public void c(boolean z) {
        this.nu = z;
    }

    public boolean c() {
        return this.nu;
    }

    public com.byazt.xf.ve tt() {
        if (this.qp == null) {
            uj ujVarC = uj.c();
            n.c(ujVarC);
            this.qp = com.byazt.xf.ve.c(ujVarC.tt());
        }
        return this.qp;
    }

    public void c(String str, float f) {
        this.sv.put(str, Float.valueOf(f));
    }

    public float c(String str) {
        return this.sv.get(str).floatValue();
    }

    public void c(long j) {
        com.byazt.ii.c.c().c(j);
    }

    public long ve() {
        long j = this.gt;
        if (j != -1) {
            return j;
        }
        long jTt = com.byazt.ii.c.c().tt();
        this.gt = jTt;
        return jTt;
    }

    private c() {
        HashMap map = new HashMap();
        this.bx = map;
        this.sv = new ConcurrentHashMap();
        if (tt.tt().l()) {
            map.put(MediationConstant.KEY_USE_POLICY_AD_GAP, 1);
            map.put(MediationConstant.KEY_USE_POLICY_AD_LOAD, 1);
            map.put(MediationConstant.KEY_USE_POLICY_SECTION_ID, 1);
            map.put(MediationConstant.KEY_USE_POLICY_PAGE_ID, 1);
            map.put(MediationConstant.KEY_USE_POLICY_OBJ_CUSTOM, 1);
        }
    }

    public Map<String, Integer> uj() {
        return this.bx;
    }

    public long n() {
        return this.pf;
    }

    public void tt(long j) {
        this.pf = j;
    }

    public String a() {
        return this.d;
    }

    public void tt(String str) {
        this.d = str;
    }

    public boolean sp() {
        return this.i;
    }

    public void tt(boolean z) {
        this.i = z;
    }

    public String x() {
        Context context = tt.getContext();
        if (context == null) {
            return null;
        }
        if ((!"com.union_test.toutiao".equals(context.getPackageName()) || !"5001121".equals(this.ve)) && (!"com.bytedance.mediation_demo".equals(context.getPackageName()) || !"5001121".equals(this.ve))) {
            return null;
        }
        try {
            return com.byazt.vif.uj.c(null, "gm_tt_mediation_ppe_info").getString("tt_ppe_content", "");
        } catch (Exception unused) {
            return null;
        }
    }

    public boolean i() {
        Context context = tt.getContext();
        return context != null && "com.bytedance.mediation_demo_csj".equals(context.getPackageName()) && sl();
    }

    public boolean da() {
        try {
            return "com.msdk.qa.monkey".equals(tt.getContext().getPackageName()) && "5001121".equals(this.ve);
        } catch (Throwable unused) {
            return false;
        }
    }

    public boolean sl() {
        String path = sp.uj(tt.getContext(), false, null).getPath();
        if (this.cu < 0) {
            if (new File(path + "/e2e.text").exists()) {
                this.cu = 1;
            } else {
                this.cu = 0;
            }
        }
        return this.cu > 0;
    }

    public static c t() {
        return aw;
    }

    public String u() {
        return this.ve;
    }

    public void ve(String str) {
        i(str);
        this.ve = str;
    }

    public void ve(boolean z) {
        this.zb = z;
    }

    public boolean yp() {
        return this.zb;
    }

    public boolean z() {
        return this.sp;
    }

    public void uj(boolean z) {
        this.sp = z;
    }

    public void uj(String str) {
        this.x = str;
    }

    public String m() {
        return this.da;
    }

    public void n(String str) {
        this.da = str;
    }

    public Map<String, String> nu() {
        return this.sl;
    }

    public void c(Map<String, String> map) {
        this.sl = map;
    }

    public String rh() {
        return this.x;
    }

    public void n(boolean z) {
        this.n = z;
    }

    public void c(int... iArr) {
        this.ic = iArr;
    }

    public void a(boolean z) {
        this.f706a = z;
    }

    public String my() {
        return this.uj;
    }

    public static String c(Context context) {
        PackageManager packageManager = context.getPackageManager();
        try {
            ApplicationInfo applicationInfo = packageManager.getApplicationInfo(context.getApplicationInfo().packageName, 0);
            String str = (String) (applicationInfo != null ? packageManager.getApplicationLabel(applicationInfo) : "");
            return str;
        } catch (Throwable th) {
            m.c(th);
            return "";
        }
    }

    public void a(String str) {
        if (TextUtils.isEmpty(str)) {
            str = c(tt.getContext());
        }
        this.uj = str;
    }

    public void c(int i) {
        this.c = i;
    }

    public void c(String[] strArr) {
        this.tt = strArr;
    }

    private static void i(String str) {
        gu.c(str, "appid不能为空");
    }

    public String gt() {
        if (!TextUtils.isEmpty(this.u)) {
            return this.u;
        }
        com.byazt.it.ve veVarC = com.byazt.vif.uj.c(null, "gm_tt_ad_mediation_sdk_sp");
        String string = veVarC.getString("any_door_id", "");
        this.u = string;
        if (!TextUtils.isEmpty(string)) {
            return this.u;
        }
        String strValueOf = String.valueOf(System.currentTimeMillis());
        veVarC.put("any_door_id", strValueOf);
        this.u = strValueOf;
        return strValueOf;
    }

    public void sp(String str) {
        this.t = str;
    }

    public a rl() {
        return this.my;
    }

    public void c(a aVar, boolean z) {
        boolean zEquals;
        if (!z) {
            a aVar2 = this.my;
            if (aVar2 == null && aVar == null) {
                zEquals = true;
            } else {
                zEquals = (aVar2 == null || aVar == null) ? false : aVar2.equals(aVar);
            }
            this.my = aVar;
            if (zEquals) {
                return;
            }
            com.byazt.qe.tt.c(tt.tt()).c().c(3, (JSONObject) null);
            return;
        }
        this.my = aVar;
    }

    public yp qy() {
        if (this.hd == null) {
            this.hd = yp.c(t().tt());
        }
        return this.hd;
    }

    public void gu() {
        this.hd = yp.c(t().tt());
    }

    public Map<String, Object> gr() {
        return this.rl;
    }

    public void tt(Map<String, Object> map) {
        if (map == null || map.size() == 0) {
            return;
        }
        this.rl.putAll(map);
    }

    public Map<String, Object> zm() {
        return this.qy;
    }

    public void ve(Map<String, Object> map) {
        if (map == null || map.size() <= 0) {
            return;
        }
        this.qy.putAll(map);
    }

    public List<String> yv() {
        return this.gu;
    }

    public void c(List<String> list) {
        this.gu = list;
    }

    public boolean p() {
        return this.gr;
    }

    public void sp(boolean z) {
        this.gr = z;
    }

    public JSONObject md() {
        return this.zm;
    }

    public void c(JSONObject jSONObject) {
        this.zm = jSONObject;
    }

    public boolean h() {
        return this.yv;
    }

    public void x(boolean z) {
        this.yv = z;
    }

    public String d() {
        return this.p;
    }

    public void x(String str) {
        this.p = str;
    }

    public boolean eo() {
        return this.md;
    }

    public void i(boolean z) {
        this.md = z;
    }

    public boolean zb() {
        return this.h;
    }

    public void da(boolean z) {
        this.h = z;
    }

    public Map<String, Object> or() {
        this.rh.put(MediationConstant.KEY_GM_USB, com.byazt.psp.n.n());
        return this.rh;
    }

    public PluginValueSet cu() {
        PluginValueSet pluginValueSet = this.or;
        return pluginValueSet != null ? pluginValueSet : com.byazt.rl.c.c().tt();
    }

    public void c(PluginValueSet pluginValueSet) {
        this.or = pluginValueSet;
    }

    public com.byazt.ko.c qp() {
        return this.eo;
    }

    public void c(com.byazt.ko.c cVar) {
        this.eo = cVar;
    }

    public Object nb() {
        return this.nb;
    }

    public void c(Object obj) {
        this.nb = obj;
    }
}
