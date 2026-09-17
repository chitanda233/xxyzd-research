package com.byazt.rb;

import com.baidu.mobads.sdk.api.IAdInterListener;
import com.czhj.sdk.common.Database.SQLiteMTAHelper;

/* JADX INFO: loaded from: classes2.dex */
public enum n {
    TRANSLATE("translate", "translation", SQLiteMTAHelper.TABLE_POINT),
    TRANSLATE_X("translateX", "translationX", "float"),
    TRANSLATE_Y("translateY", "translationY", "float"),
    ROTATE_X("rotateX", "rotationX", "float"),
    ROTATE_Y("rotateY", "rotationY", "float"),
    ROTATE_Z("rotateZ", com.sigmob.sdk.base.common.a.B, "float"),
    SCALE("scale", "scale", SQLiteMTAHelper.TABLE_POINT),
    SCALE_X("scaleX", "scaleX", "float"),
    SCALE_Y("scaleY", "scaleY", "float"),
    ALPHA("opacity", "alpha", "float"),
    BACKGROUND_COLOR("backgroundColor", "backgroundColor", IAdInterListener.AdProdType.PRODUCT_INTERSTITIAL),
    BORDER_RADIUS("borderRadius", "borderRadius", "float"),
    RIPPLE("ripple", "ripple", "float"),
    SHINE("shine", "shine", "float");

    public final String m;
    public final String nu;
    public final String z;

    n(String str, String str2, String str3) {
        this.z = str;
        this.m = str2;
        this.nu = str3;
    }

    public String c() {
        return this.z;
    }

    public String tt() {
        return this.m;
    }

    public String ve() {
        return this.nu;
    }

    public static n c(String str) {
        str.hashCode();
        switch (str) {
            case "translateX":
                return TRANSLATE_X;
            case "translateY":
                return TRANSLATE_Y;
            case "opacity":
                return ALPHA;
            case "ripple":
                return RIPPLE;
            case "scaleX":
                return SCALE_X;
            case "scaleY":
                return SCALE_Y;
            case "scale":
                return SCALE;
            case "translate":
                return TRANSLATE;
            case "backgroundColor":
                return BACKGROUND_COLOR;
            case "borderRadius":
                return BORDER_RADIUS;
            case "rotateX":
                return ROTATE_X;
            case "rotateY":
                return ROTATE_Y;
            case "rotateZ":
                return ROTATE_Z;
            default:
                return TRANSLATE_X;
        }
    }
}
