package com.bytedance.android;

import android.util.Log;
import com.bytedance.sdk.openadsdk.LocationProvider;
import com.bytedance.sdk.openadsdk.TTCustomController;
import com.bytedance.sdk.openadsdk.mediation.init.IMediationPrivacyConfig;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public class CustomController extends TTCustomController {
    private String mDevImei;
    private String mDevOaid;
    private Map<String, Object> mUserPrivacyConfig;
    private String macAddress;
    private IMediationPrivacyConfig mediationPrivacyConfig;
    private double mLatitude = Double.NaN;
    private double mLongitude = Double.NaN;
    private boolean mIsCanUseLocation = true;
    private boolean mIsCanReadAppList = true;
    private boolean mIsCanUsePhoneState = true;
    private boolean mIsCanUseWifiState = true;
    private boolean mIsCanUseWriteExternal = true;
    private boolean mIsCanUseAndroidId = true;
    private String mAndroidId = "";
    private boolean mIsCanUsePermissionRecordAudio = true;
    private boolean mIsCanUseMessage = true;

    public void canUseLocation(boolean z) {
        this.mIsCanUseLocation = z;
    }

    public void setLocationInfo(double d, double d2) {
        this.mLongitude = d;
        this.mLatitude = d2;
    }

    public void canReadAppList(boolean z) {
        this.mIsCanReadAppList = z;
    }

    public void canUsePhoneState(boolean z) {
        this.mIsCanUsePhoneState = z;
    }

    public void setDevImei(String str) {
        this.mDevImei = str;
    }

    public void canUseWifiState(boolean z) {
        this.mIsCanUseWifiState = z;
    }

    public void setMacAddress(String str) {
        this.macAddress = str;
    }

    public void canUseWriteExternal(boolean z) {
        this.mIsCanUseWriteExternal = z;
    }

    public void setDevOaid(String str) {
        this.mDevOaid = str;
    }

    public void canUseAndroidId(boolean z) {
        this.mIsCanUseAndroidId = z;
    }

    public void setAndroidId(String str) {
        this.mAndroidId = str;
    }

    public void setCanUsePermissionRecordAudio(boolean z) {
        this.mIsCanUsePermissionRecordAudio = z;
    }

    public void setCanUseMessage(boolean z) {
        this.mIsCanUseMessage = z;
        Log.i("TMe", "native csjm unity canUseMessage: " + z);
    }

    public void setMediationPrivacyConfig(IMediationPrivacyConfig iMediationPrivacyConfig) {
        this.mediationPrivacyConfig = iMediationPrivacyConfig;
    }

    public void setUserPrivacyConfig(Map<String, Object> map) {
        this.mUserPrivacyConfig = map;
        Log.i("TMe", "native csjm unity privacy: " + map);
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public IMediationPrivacyConfig getMediationPrivacyConfig() {
        return this.mediationPrivacyConfig;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUseLocation() {
        return this.mIsCanUseLocation;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public LocationProvider getTTLocation() {
        if (Double.isNaN(this.mLatitude) || Double.isNaN(this.mLongitude)) {
            return null;
        }
        return new LocationProvider() { // from class: com.bytedance.android.CustomController.1
            @Override // com.bytedance.sdk.openadsdk.LocationProvider
            public double getLatitude() {
                return CustomController.this.mLatitude;
            }

            @Override // com.bytedance.sdk.openadsdk.LocationProvider
            public double getLongitude() {
                return CustomController.this.mLongitude;
            }
        };
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean alist() {
        return this.mIsCanReadAppList;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUsePhoneState() {
        return this.mIsCanUsePhoneState;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public String getDevImei() {
        return this.mDevImei;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUseWifiState() {
        return this.mIsCanUseWifiState;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public String getMacAddress() {
        String str = this.macAddress;
        return str != null ? str : super.getMacAddress();
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUseWriteExternal() {
        return this.mIsCanUseWriteExternal;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public String getDevOaid() {
        return this.mDevOaid;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUseAndroidId() {
        return this.mIsCanUseAndroidId;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public String getAndroidId() {
        return this.mAndroidId;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUsePermissionRecordAudio() {
        return this.mIsCanUsePermissionRecordAudio;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public Map<String, Object> userPrivacyConfig() {
        return this.mUserPrivacyConfig;
    }

    @Override // com.bytedance.sdk.openadsdk.TTCustomController
    public boolean isCanUseMessage() {
        return this.mIsCanUseMessage;
    }
}
