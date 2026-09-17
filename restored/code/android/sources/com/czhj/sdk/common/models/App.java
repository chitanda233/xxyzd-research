package com.czhj.sdk.common.models;

import android.os.Parcelable;
import com.czhj.wire.AndroidMessage;
import com.czhj.wire.FieldEncoding;
import com.czhj.wire.Message;
import com.czhj.wire.ProtoAdapter;
import com.czhj.wire.ProtoReader;
import com.czhj.wire.ProtoWriter;
import com.czhj.wire.WireField;
import com.czhj.wire.internal.Internal;
import com.czhj.wire.okio.ByteString;
import java.io.IOException;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
public final class App extends AndroidMessage<App, Builder> {
    public static final ProtoAdapter<App> ADAPTER;
    public static final Parcelable.Creator<App> CREATOR;
    public static final String DEFAULT_APP_ID = "";
    public static final String DEFAULT_APP_PACKAGE = "";
    public static final String DEFAULT_APP_SHA256 = "";
    public static final String DEFAULT_CHANNEL_ID = "";
    public static final String DEFAULT_IDFV = "";
    public static final Long DEFAULT_INSTALL_TIME;
    public static final String DEFAULT_NAME = "";
    public static final Integer DEFAULT_ORIENTATION;
    public static final String DEFAULT_PRODUCT_ID = "";
    public static final Boolean DEFAULT_SUPPORT_HTTP;
    public static final String DEFAULT_SUPPORT_SK_VERSION = "";
    private static final long serialVersionUID = 0;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", label = WireField.Label.REPEATED, tag = 10)
    public final List<String> ad_network_ids;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 1)
    public final String app_id;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 3)
    public final String app_package;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 21)
    public final String app_sha256;

    @WireField(adapter = "com.sigmob.sdk.common.models.Version#ADAPTER", tag = 2)
    public final Version app_version;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 7)
    public final String channel_id;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 6)
    public final String idfv;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#INT64", tag = 15)
    public final Long install_time;

    @WireField(adapter = "com.sigmob.sdk.common.models.Version#ADAPTER", tag = 17)
    public final Version mraid1_version;

    @WireField(adapter = "com.sigmob.sdk.common.models.Version#ADAPTER", tag = 18)
    public final Version mraid2_version;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 5)
    public final String name;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#UINT32", tag = 4)
    public final Integer orientation;

    @WireField(adapter = "com.sigmob.sdk.common.models.Permission#ADAPTER", tag = 19)
    public final Permission permission;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 8)
    public final String product_id;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#UINT32", label = WireField.Label.REPEATED, tag = 12)
    public final List<Integer> sdk_ext_cap;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#BOOL", tag = 9)
    public final Boolean support_http;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 11)
    public final String support_sk_version;

    public static final class Builder extends Message.Builder<App, Builder> {
        public String app_id;
        public String app_package;
        public String app_sha256;
        public Version app_version;
        public String channel_id;
        public String idfv;
        public Long install_time;
        public Version mraid1_version;
        public Version mraid2_version;
        public String name;
        public Integer orientation;
        public Permission permission;
        public String product_id;
        public Boolean support_http;
        public String support_sk_version;
        public List<String> ad_network_ids = Internal.newMutableList();
        public List<Integer> sdk_ext_cap = Internal.newMutableList();

        public Builder ad_network_ids(List<String> list) {
            Internal.checkElementsNotNull(list);
            this.ad_network_ids = list;
            return this;
        }

        public Builder app_id(String str) {
            this.app_id = str;
            return this;
        }

        public Builder app_package(String str) {
            this.app_package = str;
            return this;
        }

        public Builder app_sha256(String str) {
            this.app_sha256 = str;
            return this;
        }

        public Builder app_version(Version version) {
            this.app_version = version;
            return this;
        }

        @Override // com.czhj.wire.Message.Builder
        public App build() {
            return new App(this.app_id, this.app_version, this.app_package, this.orientation, this.name, this.idfv, this.channel_id, this.product_id, this.support_http, this.ad_network_ids, this.support_sk_version, this.sdk_ext_cap, this.install_time, this.mraid1_version, this.mraid2_version, this.permission, this.app_sha256, super.buildUnknownFields());
        }

        public Builder channel_id(String str) {
            this.channel_id = str;
            return this;
        }

        public Builder idfv(String str) {
            this.idfv = str;
            return this;
        }

        public Builder install_time(Long l) {
            this.install_time = l;
            return this;
        }

        public Builder mraid1_version(Version version) {
            this.mraid1_version = version;
            return this;
        }

        public Builder mraid2_version(Version version) {
            this.mraid2_version = version;
            return this;
        }

        public Builder name(String str) {
            this.name = str;
            return this;
        }

        public Builder orientation(Integer num) {
            this.orientation = num;
            return this;
        }

        public Builder permission(Permission permission) {
            this.permission = permission;
            return this;
        }

        public Builder product_id(String str) {
            this.product_id = str;
            return this;
        }

        public Builder sdk_ext_cap(List<Integer> list) {
            Internal.checkElementsNotNull(list);
            this.sdk_ext_cap = list;
            return this;
        }

        public Builder support_http(Boolean bool) {
            this.support_http = bool;
            return this;
        }

        public Builder support_sk_version(String str) {
            this.support_sk_version = str;
            return this;
        }
    }

    private static final class ProtoAdapter_App extends ProtoAdapter<App> {
        public ProtoAdapter_App() {
            super(FieldEncoding.LENGTH_DELIMITED, App.class);
        }

        /* JADX WARN: Can't rename method to resolve collision */
        @Override // com.czhj.wire.ProtoAdapter
        public App decode(ProtoReader protoReader) throws IOException {
            List list;
            Object obj;
            Builder builder = new Builder();
            long jBeginMessage = protoReader.beginMessage();
            while (true) {
                int iNextTag = protoReader.nextTag();
                if (iNextTag == -1) {
                    protoReader.endMessage(jBeginMessage);
                    return builder.build();
                }
                switch (iNextTag) {
                    case 1:
                        builder.app_id(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 2:
                        builder.app_version(Version.ADAPTER.decode(protoReader));
                        continue;
                    case 3:
                        builder.app_package(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 4:
                        builder.orientation(ProtoAdapter.UINT32.decode(protoReader));
                        continue;
                    case 5:
                        builder.name(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 6:
                        builder.idfv(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 7:
                        builder.channel_id(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 8:
                        builder.product_id(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 9:
                        builder.support_http(ProtoAdapter.BOOL.decode(protoReader));
                        continue;
                    case 10:
                        list = builder.ad_network_ids;
                        obj = (String) ProtoAdapter.STRING.decode(protoReader);
                        break;
                    case 11:
                        builder.support_sk_version(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                    case 12:
                        list = builder.sdk_ext_cap;
                        obj = (Integer) ProtoAdapter.UINT32.decode(protoReader);
                        break;
                    case 13:
                    case 14:
                    case 16:
                    case 20:
                    default:
                        FieldEncoding fieldEncodingPeekFieldEncoding = protoReader.peekFieldEncoding();
                        builder.addUnknownField(iNextTag, fieldEncodingPeekFieldEncoding, fieldEncodingPeekFieldEncoding.rawProtoAdapter().decode(protoReader));
                        continue;
                    case 15:
                        builder.install_time(ProtoAdapter.INT64.decode(protoReader));
                        continue;
                    case 17:
                        builder.mraid1_version(Version.ADAPTER.decode(protoReader));
                        continue;
                    case 18:
                        builder.mraid2_version(Version.ADAPTER.decode(protoReader));
                        continue;
                    case 19:
                        builder.permission(Permission.ADAPTER.decode(protoReader));
                        continue;
                    case 21:
                        builder.app_sha256(ProtoAdapter.STRING.decode(protoReader));
                        continue;
                }
                list.add(obj);
            }
        }

        @Override // com.czhj.wire.ProtoAdapter
        public void encode(ProtoWriter protoWriter, App app) throws IOException {
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 1, app.app_id);
            Version.ADAPTER.encodeWithTag(protoWriter, 2, app.app_version);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 3, app.app_package);
            ProtoAdapter.UINT32.encodeWithTag(protoWriter, 4, app.orientation);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 5, app.name);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 6, app.idfv);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 7, app.channel_id);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 8, app.product_id);
            ProtoAdapter.BOOL.encodeWithTag(protoWriter, 9, app.support_http);
            ProtoAdapter.STRING.asRepeated().encodeWithTag(protoWriter, 10, app.ad_network_ids);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 11, app.support_sk_version);
            ProtoAdapter.UINT32.asRepeated().encodeWithTag(protoWriter, 12, app.sdk_ext_cap);
            ProtoAdapter.INT64.encodeWithTag(protoWriter, 15, app.install_time);
            Version.ADAPTER.encodeWithTag(protoWriter, 17, app.mraid1_version);
            Version.ADAPTER.encodeWithTag(protoWriter, 18, app.mraid2_version);
            Permission.ADAPTER.encodeWithTag(protoWriter, 19, app.permission);
            ProtoAdapter.STRING.encodeWithTag(protoWriter, 21, app.app_sha256);
            protoWriter.writeBytes(app.unknownFields());
        }

        @Override // com.czhj.wire.ProtoAdapter
        public int encodedSize(App app) {
            return ProtoAdapter.STRING.encodedSizeWithTag(1, app.app_id) + Version.ADAPTER.encodedSizeWithTag(2, app.app_version) + ProtoAdapter.STRING.encodedSizeWithTag(3, app.app_package) + ProtoAdapter.UINT32.encodedSizeWithTag(4, app.orientation) + ProtoAdapter.STRING.encodedSizeWithTag(5, app.name) + ProtoAdapter.STRING.encodedSizeWithTag(6, app.idfv) + ProtoAdapter.STRING.encodedSizeWithTag(7, app.channel_id) + ProtoAdapter.STRING.encodedSizeWithTag(8, app.product_id) + ProtoAdapter.BOOL.encodedSizeWithTag(9, app.support_http) + ProtoAdapter.STRING.asRepeated().encodedSizeWithTag(10, app.ad_network_ids) + ProtoAdapter.STRING.encodedSizeWithTag(11, app.support_sk_version) + ProtoAdapter.UINT32.asRepeated().encodedSizeWithTag(12, app.sdk_ext_cap) + ProtoAdapter.INT64.encodedSizeWithTag(15, app.install_time) + Version.ADAPTER.encodedSizeWithTag(17, app.mraid1_version) + Version.ADAPTER.encodedSizeWithTag(18, app.mraid2_version) + Permission.ADAPTER.encodedSizeWithTag(19, app.permission) + ProtoAdapter.STRING.encodedSizeWithTag(21, app.app_sha256) + app.unknownFields().size();
        }

        @Override // com.czhj.wire.ProtoAdapter
        public App redact(App app) {
            Builder builderNewBuilder = app.newBuilder();
            if (builderNewBuilder.app_version != null) {
                builderNewBuilder.app_version = Version.ADAPTER.redact(builderNewBuilder.app_version);
            }
            if (builderNewBuilder.mraid1_version != null) {
                builderNewBuilder.mraid1_version = Version.ADAPTER.redact(builderNewBuilder.mraid1_version);
            }
            if (builderNewBuilder.mraid2_version != null) {
                builderNewBuilder.mraid2_version = Version.ADAPTER.redact(builderNewBuilder.mraid2_version);
            }
            if (builderNewBuilder.permission != null) {
                builderNewBuilder.permission = Permission.ADAPTER.redact(builderNewBuilder.permission);
            }
            builderNewBuilder.clearUnknownFields();
            return builderNewBuilder.build();
        }
    }

    static {
        ProtoAdapter_App protoAdapter_App = new ProtoAdapter_App();
        ADAPTER = protoAdapter_App;
        CREATOR = AndroidMessage.newCreator(protoAdapter_App);
        DEFAULT_ORIENTATION = 0;
        DEFAULT_SUPPORT_HTTP = false;
        DEFAULT_INSTALL_TIME = 0L;
    }

    public App(String str, Version version, String str2, Integer num, String str3, String str4, String str5, String str6, Boolean bool, List<String> list, String str7, List<Integer> list2, Long l, Version version2, Version version3, Permission permission, String str8) {
        this(str, version, str2, num, str3, str4, str5, str6, bool, list, str7, list2, l, version2, version3, permission, str8, ByteString.EMPTY);
    }

    public App(String str, Version version, String str2, Integer num, String str3, String str4, String str5, String str6, Boolean bool, List<String> list, String str7, List<Integer> list2, Long l, Version version2, Version version3, Permission permission, String str8, ByteString byteString) {
        super(ADAPTER, byteString);
        this.app_id = str;
        this.app_version = version;
        this.app_package = str2;
        this.orientation = num;
        this.name = str3;
        this.idfv = str4;
        this.channel_id = str5;
        this.product_id = str6;
        this.support_http = bool;
        this.ad_network_ids = Internal.immutableCopyOf("ad_network_ids", list);
        this.support_sk_version = str7;
        this.sdk_ext_cap = Internal.immutableCopyOf("sdk_ext_cap", list2);
        this.install_time = l;
        this.mraid1_version = version2;
        this.mraid2_version = version3;
        this.permission = permission;
        this.app_sha256 = str8;
    }

    public boolean equals(Object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj instanceof App)) {
            return false;
        }
        App app = (App) obj;
        return unknownFields().equals(app.unknownFields()) && Internal.equals(this.app_id, app.app_id) && Internal.equals(this.app_version, app.app_version) && Internal.equals(this.app_package, app.app_package) && Internal.equals(this.orientation, app.orientation) && Internal.equals(this.name, app.name) && Internal.equals(this.idfv, app.idfv) && Internal.equals(this.channel_id, app.channel_id) && Internal.equals(this.product_id, app.product_id) && Internal.equals(this.support_http, app.support_http) && this.ad_network_ids.equals(app.ad_network_ids) && Internal.equals(this.support_sk_version, app.support_sk_version) && this.sdk_ext_cap.equals(app.sdk_ext_cap) && Internal.equals(this.install_time, app.install_time) && Internal.equals(this.mraid1_version, app.mraid1_version) && Internal.equals(this.mraid2_version, app.mraid2_version) && Internal.equals(this.permission, app.permission) && Internal.equals(this.app_sha256, app.app_sha256);
    }

    public int hashCode() {
        int i = this.hashCode;
        if (i != 0) {
            return i;
        }
        int iHashCode = unknownFields().hashCode() * 37;
        String str = this.app_id;
        int iHashCode2 = (iHashCode + (str != null ? str.hashCode() : 0)) * 37;
        Version version = this.app_version;
        int iHashCode3 = (iHashCode2 + (version != null ? version.hashCode() : 0)) * 37;
        String str2 = this.app_package;
        int iHashCode4 = (iHashCode3 + (str2 != null ? str2.hashCode() : 0)) * 37;
        Integer num = this.orientation;
        int iHashCode5 = (iHashCode4 + (num != null ? num.hashCode() : 0)) * 37;
        String str3 = this.name;
        int iHashCode6 = (iHashCode5 + (str3 != null ? str3.hashCode() : 0)) * 37;
        String str4 = this.idfv;
        int iHashCode7 = (iHashCode6 + (str4 != null ? str4.hashCode() : 0)) * 37;
        String str5 = this.channel_id;
        int iHashCode8 = (iHashCode7 + (str5 != null ? str5.hashCode() : 0)) * 37;
        String str6 = this.product_id;
        int iHashCode9 = (iHashCode8 + (str6 != null ? str6.hashCode() : 0)) * 37;
        Boolean bool = this.support_http;
        int iHashCode10 = (((iHashCode9 + (bool != null ? bool.hashCode() : 0)) * 37) + this.ad_network_ids.hashCode()) * 37;
        String str7 = this.support_sk_version;
        int iHashCode11 = (((iHashCode10 + (str7 != null ? str7.hashCode() : 0)) * 37) + this.sdk_ext_cap.hashCode()) * 37;
        Long l = this.install_time;
        int iHashCode12 = (iHashCode11 + (l != null ? l.hashCode() : 0)) * 37;
        Version version2 = this.mraid1_version;
        int iHashCode13 = (iHashCode12 + (version2 != null ? version2.hashCode() : 0)) * 37;
        Version version3 = this.mraid2_version;
        int iHashCode14 = (iHashCode13 + (version3 != null ? version3.hashCode() : 0)) * 37;
        Permission permission = this.permission;
        int iHashCode15 = (iHashCode14 + (permission != null ? permission.hashCode() : 0)) * 37;
        String str8 = this.app_sha256;
        int iHashCode16 = iHashCode15 + (str8 != null ? str8.hashCode() : 0);
        this.hashCode = iHashCode16;
        return iHashCode16;
    }

    @Override // com.czhj.wire.Message
    public Builder newBuilder() {
        Builder builder = new Builder();
        builder.app_id = this.app_id;
        builder.app_version = this.app_version;
        builder.app_package = this.app_package;
        builder.orientation = this.orientation;
        builder.name = this.name;
        builder.idfv = this.idfv;
        builder.channel_id = this.channel_id;
        builder.product_id = this.product_id;
        builder.support_http = this.support_http;
        builder.ad_network_ids = Internal.copyOf("ad_network_ids", this.ad_network_ids);
        builder.support_sk_version = this.support_sk_version;
        builder.sdk_ext_cap = Internal.copyOf("sdk_ext_cap", this.sdk_ext_cap);
        builder.install_time = this.install_time;
        builder.mraid1_version = this.mraid1_version;
        builder.mraid2_version = this.mraid2_version;
        builder.permission = this.permission;
        builder.app_sha256 = this.app_sha256;
        builder.addUnknownFields(unknownFields());
        return builder;
    }

    @Override // com.czhj.wire.Message
    public String toString() {
        StringBuilder sb = new StringBuilder();
        if (this.app_id != null) {
            sb.append(", app_id=").append(this.app_id);
        }
        if (this.app_version != null) {
            sb.append(", app_version=").append(this.app_version);
        }
        if (this.app_package != null) {
            sb.append(", app_package=").append(this.app_package);
        }
        if (this.orientation != null) {
            sb.append(", orientation=").append(this.orientation);
        }
        if (this.name != null) {
            sb.append(", name=").append(this.name);
        }
        if (this.idfv != null) {
            sb.append(", idfv=").append(this.idfv);
        }
        if (this.channel_id != null) {
            sb.append(", channel_id=").append(this.channel_id);
        }
        if (this.product_id != null) {
            sb.append(", product_id=").append(this.product_id);
        }
        if (this.support_http != null) {
            sb.append(", support_http=").append(this.support_http);
        }
        if (!this.ad_network_ids.isEmpty()) {
            sb.append(", ad_network_ids=").append(this.ad_network_ids);
        }
        if (this.support_sk_version != null) {
            sb.append(", support_sk_version=").append(this.support_sk_version);
        }
        if (!this.sdk_ext_cap.isEmpty()) {
            sb.append(", sdk_ext_cap=").append(this.sdk_ext_cap);
        }
        if (this.install_time != null) {
            sb.append(", install_time=").append(this.install_time);
        }
        if (this.mraid1_version != null) {
            sb.append(", mraid1_version=").append(this.mraid1_version);
        }
        if (this.mraid2_version != null) {
            sb.append(", mraid2_version=").append(this.mraid2_version);
        }
        if (this.permission != null) {
            sb.append(", permission=").append(this.permission);
        }
        if (this.app_sha256 != null) {
            sb.append(", app_sha256=").append(this.app_sha256);
        }
        return sb.replace(0, 2, "App{").append('}').toString();
    }
}
