package com.kwad.sdk.i;

import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class g {
    private String Nl;
    private Map<String, String> aAU;
    private JSONObject aLM;
    private String aQZ;
    private String aRa;
    private String aWY;
    private String aWc;
    private String appId;
    private JSONObject biw;
    private boolean bix;
    private String sdkVersion;

    private g() {
    }

    public static g RU() {
        return new g();
    }

    public final g gN(String str) {
        this.appId = str;
        return this;
    }

    public final g gO(String str) {
        this.sdkVersion = str;
        return this;
    }

    public final g gP(String str) {
        this.aRa = str;
        return this;
    }

    public final g gQ(String str) {
        this.Nl = str;
        return this;
    }

    public final g gR(String str) {
        this.aWY = str;
        return this;
    }

    public final g gS(String str) {
        this.aQZ = str;
        return this;
    }

    public final g n(JSONObject jSONObject) {
        this.biw = jSONObject;
        return this;
    }

    public final g cd(boolean z) {
        this.bix = z;
        return this;
    }

    public final g gT(String str) {
        this.aWc = str;
        return this;
    }

    public final g i(Map<String, String> map) {
        this.aAU = map;
        return this;
    }

    public final g o(JSONObject jSONObject) {
        this.aLM = jSONObject;
        return this;
    }

    public final String getAppId() {
        return this.appId;
    }

    public final String getSdkVersion() {
        return this.sdkVersion;
    }

    public final String getOaid() {
        return this.aRa;
    }

    public final String getDeviceId() {
        return this.Nl;
    }

    public final String getAndroidId() {
        return this.aWY;
    }

    public final String getImei() {
        return this.aQZ;
    }

    public final JSONObject RV() {
        return this.biw;
    }

    public final boolean RW() {
        return this.bix;
    }

    public final String RX() {
        return this.aWc;
    }

    public final Map<String, String> getRequestHeader() {
        return this.aAU;
    }

    public final JSONObject RY() {
        return this.aLM;
    }
}
