package com.sigmob.sdk.splash;

import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.l;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public class j extends l {
    /* JADX WARN: Can't fix incorrect switch cases order, some code will duplicate */
    /* JADX WARN: Code duplicated, block: B:22:0x0040  */
    /* JADX WARN: Code duplicated, block: B:49:0x0141 A[Catch: all -> 0x01de, TryCatch #0 {all -> 0x01de, blocks: (B:3:0x0003, B:7:0x0010, B:32:0x0052, B:34:0x005a, B:38:0x0067, B:41:0x009a, B:42:0x00b6, B:47:0x00df, B:49:0x0141, B:50:0x015a, B:54:0x0179, B:51:0x015e, B:53:0x0166, B:43:0x00ba, B:45:0x00c2, B:46:0x00d8, B:55:0x01d3, B:56:0x01d6, B:57:0x01da, B:10:0x001a, B:13:0x0022, B:16:0x002c, B:19:0x0036), top: B:62:0x0003 }] */
    /* JADX WARN: Code duplicated, block: B:51:0x015e A[Catch: all -> 0x01de, TryCatch #0 {all -> 0x01de, blocks: (B:3:0x0003, B:7:0x0010, B:32:0x0052, B:34:0x005a, B:38:0x0067, B:41:0x009a, B:42:0x00b6, B:47:0x00df, B:49:0x0141, B:50:0x015a, B:54:0x0179, B:51:0x015e, B:53:0x0166, B:43:0x00ba, B:45:0x00c2, B:46:0x00d8, B:55:0x01d3, B:56:0x01d6, B:57:0x01da, B:10:0x001a, B:13:0x0022, B:16:0x002c, B:19:0x0036), top: B:62:0x0003 }] */
    /* JADX WARN: Code duplicated, block: B:53:0x0166 A[Catch: all -> 0x01de, TryCatch #0 {all -> 0x01de, blocks: (B:3:0x0003, B:7:0x0010, B:32:0x0052, B:34:0x005a, B:38:0x0067, B:41:0x009a, B:42:0x00b6, B:47:0x00df, B:49:0x0141, B:50:0x015a, B:54:0x0179, B:51:0x015e, B:53:0x0166, B:43:0x00ba, B:45:0x00c2, B:46:0x00d8, B:55:0x01d3, B:56:0x01d6, B:57:0x01da, B:10:0x001a, B:13:0x0022, B:16:0x002c, B:19:0x0036), top: B:62:0x0003 }] */
    @Override // com.sigmob.sdk.base.common.u
    public boolean a(BaseAdUnit adUnit, String event, int currentPosition) {
        byte b;
        String str;
        String str2;
        HashMap<String, String> map;
        String str3;
        String str4;
        String str5;
        try {
            switch (event) {
                case "fourElements_show":
                    b = 3;
                    break;
                case "fourElements_close":
                    b = 4;
                    break;
                case "skip":
                    b = 1;
                    break;
                case "click":
                    b = 2;
                    break;
                case "start":
                    b = 0;
                    break;
                default:
                    b = -1;
                    break;
            }
            if (b == 0 || b == 1) {
                com.sigmob.sdk.base.network.h.a(adUnit, event);
                a(adUnit, event, (String) null, (HashMap<String, String>) null);
            } else if (b != 2) {
                if (b != 3) {
                    str5 = b == 4 ? "close" : "show";
                }
                a(adUnit, PointCategory.FOURELEMENTS, str5, (HashMap<String, String>) null);
            } else {
                ClickCommon clickCommon = adUnit.getClickCommon();
                String str6 = clickCommon.is_final_click ? "1" : "0";
                SigMacroCommon macroCommon = adUnit.getMacroCommon();
                macroCommon.addMarcoKey(SigMacroCommon._SLD_, clickCommon.sld);
                macroCommon.addMarcoKey("_AX_", clickCommon.adarea_x);
                macroCommon.addMarcoKey("_AY_", clickCommon.adarea_y);
                macroCommon.addMarcoKey("_AW_", clickCommon.adarea_w);
                macroCommon.addMarcoKey("_AH_", clickCommon.adarea_h);
                if ("5".equals(clickCommon.sld)) {
                    macroCommon.updateClickMarco(SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY);
                    macroCommon.addMarcoKey("_TURNX_", clickCommon.turn_x);
                    macroCommon.addMarcoKey("_TURNY_", clickCommon.turn_y);
                    macroCommon.addMarcoKey("_TURNZ_", clickCommon.turn_z);
                    str = "_TURNTIME_";
                    str2 = clickCommon.turn_time;
                } else {
                    if ("2".equals(clickCommon.sld)) {
                        macroCommon.updateClickMarco(SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY);
                        macroCommon.addMarcoKey("_XMAXACC_", clickCommon.x_max_acc);
                        macroCommon.addMarcoKey("_YMAXACC_", clickCommon.y_max_acc);
                        str = "_ZMAXACC_";
                        str2 = clickCommon.z_max_acc;
                    } else {
                        macroCommon.updateClickMarco(clickCommon.down, clickCommon.up);
                    }
                    macroCommon.addMarcoKey(SigMacroCommon._TEMPLATE_, String.valueOf(adUnit.getTemplateId()));
                    macroCommon.addMarcoKey(SigMacroCommon._CLICKAREA_, String.valueOf(clickCommon.click_area));
                    macroCommon.addMarcoKey(SigMacroCommon._CLICKSCENE_, String.valueOf(clickCommon.click_scene));
                    macroCommon.addMarcoKey(SigMacroCommon._FINALCLICK_, str6);
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    map = new HashMap<>();
                    map.put("template_id", clickCommon.template_id);
                    map.put("sld", clickCommon.sld);
                    map.put("adarea_x", clickCommon.adarea_x);
                    map.put("adarea_y", clickCommon.adarea_y);
                    map.put("adarea_w", clickCommon.adarea_w);
                    map.put("adarea_h", clickCommon.adarea_h);
                    if ("5".equals(clickCommon.sld)) {
                        map.put("turn_x", clickCommon.turn_x);
                        map.put("turn_y", clickCommon.turn_y);
                        map.put("turn_z", clickCommon.turn_z);
                        str3 = "turn_time";
                        str4 = clickCommon.turn_time;
                    } else {
                        if ("2".equals(clickCommon.sld)) {
                            map.put("x_max_acc", clickCommon.x_max_acc);
                            map.put("y_max_acc", clickCommon.y_max_acc);
                            str3 = "z_max_acc";
                            str4 = clickCommon.z_max_acc;
                        }
                        map.put(ClickCommon.CLICK_AREA, clickCommon.click_area);
                        map.put("click_scene", clickCommon.click_scene);
                        map.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                        map.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                        map.put("is_final_click", str6);
                        map.put("coordinate", macroCommon.getCoordinate());
                        map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                        map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                        a(adUnit, clickCommon.click_scene, "click", map);
                    }
                    map.put(str3, str4);
                    map.put(ClickCommon.CLICK_AREA, clickCommon.click_area);
                    map.put("click_scene", clickCommon.click_scene);
                    map.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                    map.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                    map.put("is_final_click", str6);
                    map.put("coordinate", macroCommon.getCoordinate());
                    map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                    map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                    a(adUnit, clickCommon.click_scene, "click", map);
                }
                macroCommon.addMarcoKey(str, str2);
                macroCommon.addMarcoKey(SigMacroCommon._TEMPLATE_, String.valueOf(adUnit.getTemplateId()));
                macroCommon.addMarcoKey(SigMacroCommon._CLICKAREA_, String.valueOf(clickCommon.click_area));
                macroCommon.addMarcoKey(SigMacroCommon._CLICKSCENE_, String.valueOf(clickCommon.click_scene));
                macroCommon.addMarcoKey(SigMacroCommon._FINALCLICK_, str6);
                com.sigmob.sdk.base.network.h.a(adUnit, event);
                map = new HashMap<>();
                map.put("template_id", clickCommon.template_id);
                map.put("sld", clickCommon.sld);
                map.put("adarea_x", clickCommon.adarea_x);
                map.put("adarea_y", clickCommon.adarea_y);
                map.put("adarea_w", clickCommon.adarea_w);
                map.put("adarea_h", clickCommon.adarea_h);
                if ("5".equals(clickCommon.sld)) {
                    map.put("turn_x", clickCommon.turn_x);
                    map.put("turn_y", clickCommon.turn_y);
                    map.put("turn_z", clickCommon.turn_z);
                    str3 = "turn_time";
                    str4 = clickCommon.turn_time;
                } else {
                    if ("2".equals(clickCommon.sld)) {
                        map.put("x_max_acc", clickCommon.x_max_acc);
                        map.put("y_max_acc", clickCommon.y_max_acc);
                        str3 = "z_max_acc";
                        str4 = clickCommon.z_max_acc;
                    }
                    map.put(ClickCommon.CLICK_AREA, clickCommon.click_area);
                    map.put("click_scene", clickCommon.click_scene);
                    map.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                    map.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                    map.put("is_final_click", str6);
                    map.put("coordinate", macroCommon.getCoordinate());
                    map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                    map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                    a(adUnit, clickCommon.click_scene, "click", map);
                }
                map.put(str3, str4);
                map.put(ClickCommon.CLICK_AREA, clickCommon.click_area);
                map.put("click_scene", clickCommon.click_scene);
                map.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                map.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                map.put("is_final_click", str6);
                map.put("coordinate", macroCommon.getCoordinate());
                map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                a(adUnit, clickCommon.click_scene, "click", map);
            }
        } catch (Throwable th) {
            SigmobLog.e(this.f3185a + "recordDisplayEvent: error = " + th.getMessage());
        }
        return true;
    }

    @Override // com.sigmob.sdk.base.common.u
    public boolean b(BaseAdUnit adUnit) {
        com.sigmob.sdk.base.network.h.a(adUnit, com.sigmob.sdk.base.common.a.u);
        a(adUnit, com.sigmob.sdk.base.common.a.u, (String) null, (HashMap<String, String>) null);
        return true;
    }
}
