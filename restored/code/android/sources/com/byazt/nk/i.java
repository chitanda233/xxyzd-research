package com.byazt.nk;

import android.content.Context;
import android.text.TextUtils;
import com.byazt.tm.DynamicBaseWidget;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 234, 42})
public class i {
    public static sp c(Context context, DynamicBaseWidget dynamicBaseWidget, com.byazt.aq.sp spVar, com.byazt.aq.da daVar, com.byazt.xl.u uVar) {
        if (context == null || dynamicBaseWidget == null || spVar == null) {
            return null;
        }
        String strAw = spVar.aw();
        String strYv = uVar.yv();
        strAw.hashCode();
        switch (strAw) {
            case "0":
                return new n(context, dynamicBaseWidget, spVar);
            case "1":
                return new ve(context, dynamicBaseWidget, spVar);
            case "2":
                return new tt(context, dynamicBaseWidget, spVar);
            case "5":
                if (spVar.hd() == 1) {
                    return new nu(context, dynamicBaseWidget, spVar, spVar.kk());
                }
                return new m(context, dynamicBaseWidget, spVar);
            case "6":
            case "11":
                return new u(context, dynamicBaseWidget, spVar);
            case "7":
            case "14":
                return new sl(context, dynamicBaseWidget, spVar);
            case "8":
                return new t(context, dynamicBaseWidget, spVar);
            case "9":
            case "16":
                return new yp(context, dynamicBaseWidget, spVar, strAw, daVar, uVar.i(), uVar.md());
            case "10":
                return new uj(context, dynamicBaseWidget, spVar);
            case "12":
                return new m(context, dynamicBaseWidget, spVar);
            case "13":
                return new nu(context, dynamicBaseWidget, spVar);
            case "17":
            case "18":
                return new my(context, dynamicBaseWidget, spVar, strAw, daVar, uVar.i(), uVar.md());
            case "20":
                if (com.byazt.sr.uj.c()) {
                    return new da(context, dynamicBaseWidget, spVar, strYv + "static/lotties/glass-swipe/glass-swipe.json", "20");
                }
                return new da(context, dynamicBaseWidget, spVar, TextUtils.isEmpty(strYv) ? null : strYv + "brush_mask.json", "20");
            case "22":
                if (com.byazt.sr.uj.c()) {
                    return new da(context, dynamicBaseWidget, spVar, strYv + "static/lotties/202327swiper-up-star/index.json", "22");
                }
                return new rh(context, dynamicBaseWidget, spVar);
            case "23":
                if (com.byazt.sr.uj.c()) {
                    return new da(context, dynamicBaseWidget, spVar, strYv + "static/lotties/202327swiper-up-star/click.json", "23");
                }
                return null;
            case "24":
                if (com.byazt.sr.uj.c()) {
                    return new c(context, dynamicBaseWidget, spVar);
                }
                return new da(context, dynamicBaseWidget, spVar, TextUtils.isEmpty(strYv) ? null : strYv + "swiper_up_star.json", "24");
            case "25":
                if (com.byazt.sr.uj.c()) {
                    return new da(context, dynamicBaseWidget, spVar, strYv + "static/lotties/gesture-slide.json", "25");
                }
                return null;
            case "29":
                return new a(context, dynamicBaseWidget, spVar, daVar, uVar.i(), uVar.md());
            default:
                return null;
        }
    }
}
