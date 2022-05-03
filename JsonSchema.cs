namespace WindowsFormsApp1
{
    /// <summary>
    /// Class that contains valid .json file scheme.
    /// </summary>
    public class JsonSchema
    {
        public string schemaJson = @"
        {
            ""type"": ""object"",
            ""required"": [],
            ""properties"": {
                ""Interface Settings"": {
                    ""type"": ""object"",
                    ""required"": [],
                    ""properties"": {
                        ""1th_interface"": {
                            ""type"": ""string""
                        },
                        ""2nd_interface"": {
                            ""type"": ""string""
                        }
                    }
                },
                ""Media Interface Settings"": {
                    ""type"": ""object"",
                    ""required"": [],
                    ""properties"": {
                        ""Network Status Indicator Configuration 1"": {
                            ""type"": ""object"",
                            ""required"": [],
                            ""properties"": {
                                ""CONF1_ENABLE"": {
                                    ""type"": ""string""
                                },
                                ""PACKAGE_ID"": {
                                    ""type"": ""string""
                                },
                                ""CONF2"": {
                                    ""type"": ""string""
                                },
                                ""VERSION"": {
                                    ""type"": ""string""
                                },
                                ""CONF3"": {
                                    ""type"": ""string""
                                },
                                ""CONF4"": {
                                    ""type"": ""string""
                                },
                                ""PACKAGE_ID_PROTOCOL_0"": {
                                    ""type"": ""string""
                                },
                                ""PACKAGE_ID_PROTOCOL_1"": {
                                    ""type"": ""string""
                                },
                                ""READ_PACKAGE_ID_FROM_PROTOCOL"": {
                                    ""type"": ""string""
                                }
                            }
                        },
                        ""Hardware Timeout"": {
                            ""type"": ""object"",
                            ""required"": [],
                            ""properties"": {
                                ""TIMEOUT"": {
                                    ""type"": ""string""
                                }
                            }
                        }
                    }
                },
                ""Port Settings"": {
                    ""type"": ""object"",
                    ""required"": [],
                    ""properties"": {
                        ""SET_0"": {
                            ""type"": ""string""
                        },
                        ""SET_1"": {
                            ""type"": ""string""
                        },
                        ""SET_2"": {
                            ""type"": ""string""
                        },
                        ""SET_3"": {
                            ""type"": ""string""
                        },
                        ""SET_4"": {
                            ""type"": ""string""
                        },
                        ""SET_5"": {
                            ""type"": ""string""
                        },
                        ""SET_6"": {
                            ""type"": ""string""
                        },
                        ""SET_7"": {
                            ""type"": ""string""
                        }
                    }
                },
                ""Unique ID"": {
                    ""type"": ""object"",
                    ""required"": [],
                    ""properties"": {
                        ""TIME_0"": {
                            ""type"": ""string""
                        },
                        ""TIME_1"": {
                            ""type"": ""string""
                        },
                        ""TIME_2"": {
                            ""type"": ""string""
                        },
                        ""TIME_3"": {
                            ""type"": ""string""
                        },
                        ""TIME_4"": {
                            ""type"": ""string""
                        },
                        ""NODE_0"": {
                            ""type"": ""string""
                        },
                        ""NODE_1"": {
                            ""type"": ""string""
                        },
                        ""NODE_2"": {
                            ""type"": ""string""
                        }
                    }
                },
                ""MAC Address"": {
                    ""type"": ""object"",
                    ""required"": [],
                    ""properties"": {
                        ""MAC_0"": {
                            ""type"": ""string""
                        }
                    }
                },
                ""Component Interconnect ID"": {
                    ""type"": ""object"",
                    ""required"": [],
                    ""properties"": {
                        ""DEVICE_0_ID"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_0"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_1"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_2"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_3"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_4"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_5"": {
                            ""type"": ""string""
                        },  
                        ""D0_ID_6"": {
                            ""type"": ""string""
                        },
                        ""D0_ID_7"": {
                            ""type"": ""string""
                        },
                        ""DEVICE_1_ID"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_0"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_1"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_2"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_3"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_4"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_5"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_6"": {
                            ""type"": ""string""
                        },
                        ""D1_ID_7"": {
                            ""type"": ""string""
                        }
                    }
                }
            }
        }
        ";
    }
}
