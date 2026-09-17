package com.byazt.sa;

import android.content.Context;
import android.graphics.Color;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import com.byazt.cd.x;
import com.byazt.nw.Swiper;
import com.byazt.sz.a;
import com.byazt.sz.z;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 795, 13})
public class tt extends com.byazt.xj.c<Swiper> implements com.byazt.nw.c {
    public String az;
    public int ca;
    public float cf;
    public int cl;
    public int di;
    public boolean e;
    public boolean ej;
    public boolean gk;
    public float hg;
    public String ij;
    public float is;
    public int iw;
    public float iy;
    public String jg;
    public float jt;
    public float k;
    public boolean kz;
    public float mq;
    public float nc;
    public float nl;
    public boolean nx;
    public boolean pe;
    public int pl;
    public JSONArray sd;
    public float vi;
    public boolean vp;
    public float w;
    public int yo;

    public tt(Context context) {
        super(context);
        this.yo = 0;
        this.vp = true;
        this.kz = true;
        this.vi = 500.0f;
        this.mq = -1.0f;
        this.cf = 2000.0f;
        this.ij = "slide";
        this.az = "dot";
        this.is = 8.0f;
        this.jt = 8.0f;
        this.w = 50.0f;
        this.nl = 90.0f;
        this.ej = false;
        this.pl = Color.parseColor("#666666");
        this.di = Color.parseColor("#ffffff");
        this.jg = "row";
        this.hg = 1.0f;
        this.k = 0.0f;
        this.iy = 0.0f;
        this.nc = 0.0f;
        this.ca = 0;
        this.cl = 0;
        this.gk = true;
        this.e = false;
        this.pe = true;
        float fC = x.c(this.tt, 8.0f);
        this.is = fC;
        this.jt = fC;
    }

    @Override // com.byazt.xj.ve
    public View c() {
        this.n = new Swiper(this.tt);
        ((Swiper) this.n).c((uj) this);
        return this.n;
    }

    @Override // com.byazt.xj.c, com.byazt.xj.ve
    public void tt() {
        super.tt();
        ((Swiper) this.n).ve((int) this.vi).n(this.e).c(this.az).c(this.is).tt(this.jt).ve(this.w).uj(this.nl).tt(this.jg).c(this.yo).tt().uj(this.vp).c(this.kz).tt((int) this.vi).uj((int) this.cf).n((int) this.mq).tt(this.gk).ve(this.ej).sp(this.pl).a(this.di).i((int) this.iy).da((int) this.nc).x((int) this.k).n(this.hg).ve(this.ij).yp(this.cl);
        ((Swiper) this.n).setOnPageChangeListener(this);
        if (this.ca == 1) {
            q();
        } else {
            b();
        }
        ((Swiper) this.n).ve();
    }

    @Override // com.byazt.xj.c
    public void c(com.byazt.xj.ve veVar) {
        if (veVar == null) {
            return;
        }
        this.c.add(veVar);
    }

    @Override // com.byazt.xj.c
    public void c(com.byazt.xj.ve veVar, ViewGroup.LayoutParams layoutParams) {
        if (veVar == null) {
            return;
        }
        this.c.add(veVar);
    }

    @Override // com.byazt.xj.ve
    public void c(String str, String str2) {
        super.c(str, str2);
        if (TextUtils.isEmpty(str)) {
        }
        str.hashCode();
        switch (str) {
            case "startDelay":
                this.mq = com.byazt.cd.ve.c(str2, -1.0f);
                break;
            case "startIndex":
                this.cl = com.byazt.cd.ve.c(str2, 0);
                break;
            case "indicatorColor":
                this.pl = com.byazt.cd.c.c(str2, this.pl);
                break;
            case "indicatorStyle":
                this.az = str2;
                break;
            case "indicatorWidth":
                this.is = x.c(this.tt, com.byazt.cd.ve.c(str2, 8.0f));
                break;
            case "indicatorHeight":
                this.jt = x.c(this.tt, com.byazt.cd.ve.c(str2, 8.0f));
                break;
            case "nextMargin":
                this.nc = x.c(this.tt, com.byazt.cd.ve.c(str2, 0.0f));
                break;
            case "driveMode":
                this.ca = com.byazt.cd.ve.c(str2, 0);
                break;
            case "effect":
                this.ij = str2;
                break;
            case "direction":
                if (TextUtils.equals(str2, "vertical")) {
                    this.yo = 1;
                    break;
                } else {
                    this.yo = 0;
                    break;
                }
                break;
            case "disableOnInteraction":
                this.e = com.byazt.cd.ve.c(str2, false);
                break;
            case "indicator":
                this.ej = com.byazt.cd.ve.c(str2, false);
                break;
            case "indicatorX":
                this.w = com.byazt.cd.ve.c(str2, 50.0f);
                break;
            case "indicatorY":
                this.nl = com.byazt.cd.ve.c(str2, 90.0f);
                break;
            case "previousMargin":
                this.iy = x.c(this.tt, com.byazt.cd.ve.c(str2, 0.0f));
                break;
            case "loop":
                this.vp = com.byazt.cd.ve.c(str2, true);
                break;
            case "delay":
                this.cf = com.byazt.cd.ve.c(str2, 2000.0f);
                break;
            case "speed":
                this.vi = com.byazt.cd.ve.c(str2, 500.0f);
                break;
            case "indicatorDirection":
                this.jg = str2;
                break;
            case "allowTouchMove":
                this.gk = com.byazt.cd.ve.c(str2, true);
                break;
            case "pageCount":
                this.hg = com.byazt.cd.ve.c(str2, 1.0f);
                break;
            case "pageMargin":
                this.k = x.c(this.tt, com.byazt.cd.ve.c(str2, 0.0f));
                break;
            case "indicatorSelectedColor":
                this.di = com.byazt.cd.c.c(str2, this.di);
                break;
            case "autoplay":
                this.kz = com.byazt.cd.ve.c(str2, true);
                break;
            case "dataList":
                this.sd = com.byazt.cd.tt.c(this.uj, str2, null);
                break;
        }
    }

    private void b() {
        if (this.c == null || this.c.isEmpty()) {
            return;
        }
        com.byazt.xj.ve<View> veVar = this.c.get(0);
        if (this.sd == null) {
            return;
        }
        for (int i = 0; i < this.sd.length(); i++) {
            z zVar = new z(this.tt);
            c(zVar);
            zVar.c(this.hq);
            try {
                JSONObject jSONObjectOptJSONObject = this.sd.optJSONObject(i);
                if (jSONObjectOptJSONObject != null) {
                    if (jSONObjectOptJSONObject.has("$chunk")) {
                        this.uj.put("$item", jSONObjectOptJSONObject.optJSONArray("$chunk"));
                    } else {
                        this.uj.put("$item", jSONObjectOptJSONObject);
                    }
                    ((Swiper) this.n).c(zVar.c(veVar.md(), this.uj, (JSONObject) null));
                }
            } catch (Throwable unused) {
            }
        }
    }

    private void q() {
        for (int i = 0; i < this.c.size(); i++) {
            com.byazt.xj.ve<View> veVar = this.c.get(i);
            if (veVar != null) {
                z zVar = new z(this.tt);
                c(zVar);
                zVar.c(this.hq);
                ((Swiper) this.n).c(zVar.c(veVar.md(), this.uj, (JSONObject) null));
            }
        }
    }

    private int kk() {
        if (this.ca == 1) {
            if (this.c != null) {
                return this.c.size();
            }
            return 0;
        }
        JSONArray jSONArray = this.sd;
        if (jSONArray != null) {
            return jSONArray.length();
        }
        return 0;
    }

    @Override // com.byazt.nw.c
    public void c(boolean z, int i, float f, int i2) {
        c(z, i, f);
    }

    @Override // com.byazt.nw.c
    public void c(boolean z, int i, int i2, boolean z2, boolean z3) {
        if (this.iw != i) {
            a(i);
            sp(i);
            this.iw = i;
        }
    }

    @Override // com.byazt.nw.c
    public void c(boolean z, int i) {
        if (i != 0) {
            if (i != 1) {
                return;
            }
            this.nx = true;
        } else {
            if (!z) {
                this.pe = true;
            }
            this.nx = false;
        }
    }

    private void a(int i) {
        if (this.pn == null) {
            return;
        }
        if (this.iw == 0 && i == kk() - 1) {
            this.pn.c("SwiperView://reloop", 1);
        }
        if (this.iw == kk() - 1 && i == 0) {
            this.pn.c("SwiperView://reloop", 0);
        }
    }

    private void sp(int i) {
        if (this.pn == null) {
            return;
        }
        this.pn.c("SwiperView://slide", Integer.valueOf(this.iw), Integer.valueOf(i), Integer.valueOf(!this.nx ? 1 : 0));
    }

    private void c(boolean z, int i, float f) {
        if (this.pn != null && !z && i == kk() - 1 && f == 0.0f && this.pe) {
            this.pn.c("SwiperView://finish", new Object[0]);
            this.pe = false;
        }
    }

    private void c(z zVar) {
        if (this.e) {
            zVar.c(new a() { // from class: com.byazt.sa.tt.1
                @Override // com.byazt.sz.a
                public void c(com.byazt.xj.ve veVar, String str, List<com.byazt.pm.a.c> list) {
                    if ((TextUtils.equals(str, "tap") || TextUtils.equals(str, "slide") || TextUtils.equals(str, "touchStart") || TextUtils.equals(str, "touchEnd")) && tt.this.n != null) {
                        ((Swiper) tt.this.n).n();
                    }
                }
            });
        }
    }
}
