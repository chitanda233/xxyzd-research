package com.kwad.sdk.utils;

import android.os.Build;
import android.text.TextUtils;
import com.byazt.bv.BaseConstants;

/* JADX INFO: loaded from: classes3.dex */
public final class bd {
    private static String bpY;
    private static String bpZ;

    public static boolean Wj() {
        return hY("EMUI");
    }

    public static boolean Wk() {
        return hY("MIUI");
    }

    public static boolean UK() {
        return hY("VIVO");
    }

    public static boolean UJ() {
        return hY(BaseConstants.ROM_OPPO_UPPER_CONSTANT);
    }

    public static boolean Wl() {
        return hY("FLYME");
    }

    public static boolean Wm() {
        return hY("SMARTISAN");
    }

    public static String getName() {
        if (bpY == null) {
            hY("");
        }
        return bpY;
    }

    public static String getVersion() {
        if (bpZ == null) {
            hY("");
        }
        return bpZ;
    }

    private static boolean hY(String str) {
        String str2 = bpY;
        if (str2 != null) {
            return str2.contains(str);
        }
        String str3 = bs.get("ro.build.version.opporom");
        bpZ = str3;
        if (!TextUtils.isEmpty(str3)) {
            bpY = BaseConstants.ROM_OPPO_UPPER_CONSTANT;
        } else {
            String str4 = bs.get("ro.vivo.os.version");
            bpZ = str4;
            if (!TextUtils.isEmpty(str4)) {
                bpY = "VIVO";
            } else {
                String str5 = bs.get(com.alipay.sdk.m.d.a.f272a);
                bpZ = str5;
                if (!TextUtils.isEmpty(str5)) {
                    bpY = "EMUI";
                } else {
                    String str6 = bs.get("ro.miui.ui.version.name");
                    bpZ = str6;
                    if (!TextUtils.isEmpty(str6)) {
                        bpY = "MIUI";
                    } else {
                        String str7 = bs.get("ro.product.system.manufacturer");
                        bpZ = str7;
                        if (!TextUtils.isEmpty(str7)) {
                            bpY = "OnePlus";
                        } else {
                            String str8 = bs.get("ro.smartisan.version");
                            bpZ = str8;
                            if (!TextUtils.isEmpty(str8)) {
                                bpY = "SMARTISAN";
                            } else if (bs.get("ro.product.manufacturer").toUpperCase().contains("SAMSUNG")) {
                                bpY = "SAMSUNG";
                            } else {
                                String str9 = Build.DISPLAY;
                                bpZ = str9;
                                if (str9.toUpperCase().contains("FLYME")) {
                                    bpY = "FLYME";
                                } else {
                                    bpZ = "unknown";
                                    bpY = Build.MANUFACTURER.toUpperCase();
                                }
                            }
                        }
                    }
                }
            }
        }
        return bpY.contains(str);
    }
}
