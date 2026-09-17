package com.sigmob.sdk.base.common;

/* JADX INFO: loaded from: classes3.dex */
public class d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3166a = 1;
    public static final int b = 2;
    public static final int c = 3;
    public static final int d = 4;
    public static final int e = 5;
    public static final int f = 6;
    public static final int g = 7;

    public static String a(int formatCode) {
        switch (formatCode) {
            case 1:
                return "REWARD_VIDEO";
            case 2:
                return "SPLASH";
            case 3:
                return "DRIFT";
            case 4:
                return "FULLSCREEN_VIDEO";
            case 5:
                return "UNIFIED_NATIVE";
            case 6:
                return "NEW_INTERSTITIAL";
            case 7:
                return "BANNER";
            default:
                return "UNKNOWN_AD_FORMAT";
        }
    }
}
