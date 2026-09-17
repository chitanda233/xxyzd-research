package com.sigmob.sdk.base.models;

import android.content.Context;
import android.os.SystemClock;
import android.view.MotionEvent;
import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.common.track.BaseMacroCommon;
import com.czhj.sdk.common.utils.Dips;
import com.czhj.sdk.common.utils.TouchLocation;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.b;
import com.sigmob.sdk.base.utils.s;
import java.util.Locale;
import java.util.Random;

/* JADX INFO: loaded from: classes3.dex */
public class SigMacroCommon extends BaseMacroCommon {
    public static final String DEFAULT_XY = "-999";
    public static final String _ADSCENEID_ = "_ADSCENEID_";
    public static final String _ADSCENE_ = "_ADSCENE_";
    public static final String _BEGINTIME_ = "_BEGINTIME_";
    public static final String _BEHAVIOR_ = "_BEHAVIOR_";
    public static final String _CLICKAREA_ = "_CLICKAREA_";
    public static final String _CLICKID_ = "_CLICKID_";
    public static final String _CLICKSCENE_ = "_CLICKSCENE_";
    public static final String _COMPLETED_ = "_COMPLETED_";
    public static final String _CURRENCY_ = "_CURRENCY_";
    public static final String _DOWNTS_ = "_DOWNTS_";
    public static final String _DOWNX_ = "_DOWNX_";
    public static final String _DOWNY_ = "_DOWNY_";
    public static final String _ENDTIME_ = "_ENDTIME_";
    public static final String _FINALCLICK_ = "_FINALCLICK_";
    public static final String _HEIGHT_ = "_HEIGHT_";
    public static final String _HIGHESTLOSSPRICE_ = "_HIGHESTLOSSPRICE_";
    public static final String _ISNC_ = "_ISNC_";
    public static final String _IS_TRUNCATION_ = "_ISTRUNCATION_";
    public static final String _PLAYFIRSTFRAME_ = "_PLAYFIRSTFRAME_";
    public static final String _PLAYLASTFRAME_ = "_PLAYLASTFRAME_";
    public static final String _PROGRESS_ = "_PROGRESS_";
    public static final String _PUBLISHERPRICE_ = "_PUBLISHERPRICE_";
    public static final String _SCENE_ = "_SCENE_";
    public static final String _SETCLOSETIME_ = "_SETCLOSETIME_";
    public static final String _SHOWSKIPTIME_ = "_SHOWSKIPTIME_";
    public static final String _SLD_ = "_SLD_";
    public static final String _SLOTHEIGHT_ = "_SLOTHEIGHT_";
    public static final String _SLOTWIDTH_ = "_SLOTWIDTH_";
    public static final String _STATUS_ = "_STATUS_";
    public static final String _TEMPLATE_ = "_TEMPLATE_";
    public static final String _TYPE_ = "_TYPE_";
    public static final String _UPTS_ = "_UPTS_";
    public static final String _UPX_ = "_UPX_";
    public static final String _UPY_ = "_UPY_";
    public static final String _VIDEOTIME_ = "_VIDEOTIME_";
    public static final String _VMD5_ = "_VMD5_";
    public static final String _VURL_ = "_VURL_";
    public static final String _WIDTH_ = "_WIDTH_";
    private static final long serialVersionUID = 1;
    private static final long initialUptimeMillis = SystemClock.uptimeMillis();
    private static final long initialCurrentTimeMillis = System.currentTimeMillis();

    public static long convertUptimeMillisToCurrentTimeMillis(long uptimeMillis) {
        return initialCurrentTimeMillis + (uptimeMillis - initialUptimeMillis);
    }

    public static String getCoordinate(MotionEvent down, MotionEvent up, boolean isRaw) {
        Context contextE = b.e();
        return String.format(Locale.getDefault(), "%d,%d,%d,%d", Integer.valueOf(Dips.pixelsToIntDips(isRaw ? down.getRawX() : down.getX(), contextE)), Integer.valueOf(Dips.pixelsToIntDips(isRaw ? down.getRawY() : down.getY(), contextE)), Integer.valueOf(Dips.pixelsToIntDips(isRaw ? up.getRawX() : up.getX(), contextE)), Integer.valueOf(Dips.pixelsToIntDips(isRaw ? up.getRawY() : up.getY(), contextE)));
    }

    /* JADX WARN: Code duplicated, block: B:33:0x0065  */
    private static String getMacroValue(String macroName) {
        try {
            switch (macroName) {
                case "_TYPE_":
                    return "1";
                case "_SCENE_":
                case "_STATUS_":
                    return "0";
                case "_BEHAVIOR_":
                    return "2";
                case "_BEGINTIME_":
                    return "0";
                case "_SLOTWIDTH_":
                case "_WIDTH_":
                    return String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip());
                case "_SLOTHEIGHT_":
                case "_HEIGHT_":
                    return String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip());
                default:
                    return "unFind";
            }
        } catch (Throwable unused) {
        }
    }

    public String getCoordinate() {
        return String.format("%s,%s,%s,%s", getMarcoKey(_DOWNX_), getMarcoKey(_DOWNY_), getMarcoKey(_UPX_), getMarcoKey(_UPY_));
    }

    @Override // com.czhj.sdk.common.track.BaseMacroCommon
    public String replaceWithDefault(String key) {
        String strReplaceWithDefault = super.replaceWithDefault(key);
        SigmobLog.d("macroProcess() called with:[" + key + "][" + strReplaceWithDefault + "]");
        if (s.b(strReplaceWithDefault) && !strReplaceWithDefault.equals("unFind")) {
            return strReplaceWithDefault;
        }
        try {
            String macroValue = getMacroValue(key);
            SigmobLog.d("macroProcess() called with: [" + key + "][" + macroValue + "]");
            if (!s.b(macroValue) || macroValue.equals("unFind")) {
                return null;
            }
            return macroValue;
        } catch (Throwable th) {
            SigmobLog.e(th.getMessage());
            return null;
        }
    }

    public void updateClickMarco(MotionEvent down, MotionEvent up, boolean isRaw) {
        if (down == null) {
            down = up;
        }
        Context contextE = b.e();
        float rawX = isRaw ? down.getRawX() : down.getX();
        float rawY = isRaw ? down.getRawY() : down.getY();
        float rawX2 = isRaw ? up.getRawX() : up.getX();
        float rawY2 = isRaw ? up.getRawY() : up.getY();
        long eventTime = down.getEventTime();
        long eventTime2 = up.getEventTime();
        addMarcoKey(_DOWNX_, String.valueOf(Dips.pixelsToIntDips(rawX, contextE)));
        addMarcoKey(_DOWNY_, String.valueOf(Dips.pixelsToIntDips(rawY, contextE)));
        addMarcoKey(_UPX_, String.valueOf(Dips.pixelsToIntDips(rawX2, contextE)));
        addMarcoKey(_UPY_, String.valueOf(Dips.pixelsToIntDips(rawY2, contextE)));
        addMarcoKey(_DOWNTS_, String.valueOf(convertUptimeMillisToCurrentTimeMillis(eventTime)));
        addMarcoKey(_UPTS_, String.valueOf(convertUptimeMillisToCurrentTimeMillis(eventTime2)));
        addMarcoKey(_SLD_, "0");
    }

    public void updateClickMarco(TouchLocation down, TouchLocation up) {
        if (down == null && up == null) {
            return;
        }
        Context contextE = b.e();
        TouchLocation touchLocation = down == null ? up : down;
        if (up != null) {
            down = up;
        }
        updateClickMarco(String.valueOf(Dips.pixelsToIntDips(touchLocation.getX(), contextE)), String.valueOf(Dips.pixelsToIntDips(touchLocation.getY(), contextE)), String.valueOf(Dips.pixelsToIntDips(down.getX(), contextE)), String.valueOf(Dips.pixelsToIntDips(down.getY(), contextE)));
        addMarcoKey(_SLD_, "0");
    }

    public void updateClickMarco(String dx, String dy, String ux, String uy) {
        addMarcoKey(_DOWNX_, dx);
        addMarcoKey(_DOWNY_, dy);
        addMarcoKey(_UPX_, ux);
        addMarcoKey(_UPY_, uy);
        if (dx.equals(DEFAULT_XY)) {
            return;
        }
        String marcoKey = getMarcoKey(_DOWNTS_);
        String marcoKey2 = getMarcoKey(_UPTS_);
        if (s.b(marcoKey) && s.b(marcoKey2)) {
            return;
        }
        Random random = new Random();
        addMarcoKey(_DOWNTS_, String.valueOf(System.currentTimeMillis()));
        addMarcoKey(_UPTS_, String.valueOf(System.currentTimeMillis() + ((long) random.nextInt(50))));
    }
}
